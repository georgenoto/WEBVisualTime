using System.Reflection;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using WEBVisualTime.Datos;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Entidades.Common;
using System.Text.RegularExpressions;

// The connection is deliberately unused: these checks inspect metadata and generate SQL only.
using var context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
    .UseOracle("Data Source=unused;User Id=unused;Password=unused").Options);
var model = context.Model;
var checks = 0;
void Check(bool value, string message) { if (!value) throw new InvalidOperationException(message); checks++; }
Check(model.GetEntityTypes().Count() == 1017, "All entities must remain available");
foreach (var fk in model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
{
    Check(fk.Properties.Count == fk.PrincipalKey.Properties.Count, "Incomplete FK: " + fk.DeclaringEntityType.Name);
    for (var i = 0; i < fk.Properties.Count; i++)
    {
        var source = fk.Properties[i]; var target = fk.PrincipalKey.Properties[i];
        Check((Nullable.GetUnderlyingType(source.ClrType) ?? source.ClrType) == (Nullable.GetUnderlyingType(target.ClrType) ?? target.ClrType), "FK type mismatch: " + source.Name);
        Check(!source.IsShadowProperty(), "Unexpected implicit FK column: " + source.Name);
    }
}
var expected = JsonSerializer.Deserialize<List<ExpectedRelationship>>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"OracleCompositeKeys.json")))!;
foreach (var relationship in expected)
{
    var sourceType = typeof(APPUSER).Assembly.GetType("WEBVisualTime.Entidades.Insudb." + relationship.Entity)!;
    var entity = model.FindEntityType(sourceType)!;
    var navigation = entity.FindNavigation(relationship.Navigation);
    Check(navigation is not null, "Missing composite navigation: " + relationship.Entity + "." + relationship.Navigation);
    var fk = navigation!.ForeignKey;
    Check(fk.PrincipalEntityType.ClrType.Name == relationship.Target, "Wrong principal table");
    Check(fk.Properties.Select(p=>p.Name).SequenceEqual(relationship.ForeignKeys), "Wrong FK tuple for Oracle constraint " + relationship.Constraint);
    Check(fk.PrincipalKey.Properties.Select(p=>p.Name).SequenceEqual(relationship.PrincipalKeys), "Wrong principal key order for Oracle constraint " + relationship.Constraint);
    var instance = Activator.CreateInstance(sourceType)!;
    var canonical = sourceType.GetProperty(relationship.Navigation)!;
    foreach (var alias in relationship.Aliases)
    {
        Check(entity.FindNavigation(alias) is null && entity.FindProperty(alias) is null, "Alias must not create additional joins");
        var first = Activator.CreateInstance(fk.PrincipalEntityType.ClrType)!;
        canonical.SetValue(instance, first);
        var aliasProperty = sourceType.GetProperty(alias)!;
        Check(ReferenceEquals(first, aliasProperty.GetValue(instance)), "Alias getter must use canonical navigation");
        var second = Activator.CreateInstance(fk.PrincipalEntityType.ClrType)!;
        aliasProperty.SetValue(instance, second);
        Check(ReferenceEquals(second, canonical.GetValue(instance)), "Alias setter must use canonical navigation");
    }
}
var userFk = model.FindEntityType(typeof(NONWORKINGDAYFACTOR))!.FindNavigation(nameof(NONWORKINGDAYFACTOR.APPUSER))!.ForeignKey;
Check((Nullable.GetUnderlyingType(userFk.Properties.Single().ClrType) ?? userFk.Properties.Single().ClrType) == typeof(long) && userFk.PrincipalKey.Properties.Single().ClrType == typeof(long), "Original NONWORKINGDAYFACTOR failure must remain fixed");
var agency = new TAB_BK_AGE { NBANK_CODE=7, NBK_AGENCY=11, SDESCRIPT="Agency" };
var account = new BANK_ACC { NBANK_CODE=7, NBK_AGENCY=11, TAB_BK_AGENBANK_CODE=agency };
var dto = account.ToDto();
Check(dto.TAB_BK_AGENBANK_CODESDESCRIPT == "Agency" && dto.TAB_BK_AGENBK_AGENCYSDESCRIPT == "Agency", "Existing DTO projections must keep alias values");
var sql = context.BANK_ACCs.Include(e=>e.TAB_BK_AGENBANK_CODE).ToQueryString();
Check(sql.Contains("NBANK_CODE") && sql.Contains("NBK_AGENCY"), "Composite join SQL must contain both key columns");
var clientEntity = model.FindEntityType(typeof(CLIENT))!;
Check(clientEntity.FindProperty(nameof(CLIENT.NAFP))!.IsNullable, "Oracle CLIENT.NAFP allows NULL");
Check(clientEntity.GetNavigations().All(n=>!n.ForeignKey.IsRequired), "Optional CLIENT catalogs must not discard clients through INNER JOINs");
IQueryable<CLIENT> clientQuery = context.CLIENTs.AsNoTracking();
foreach(var navigation in clientEntity.GetNavigations())clientQuery=clientQuery.Include(navigation.Name);
var clientSql=clientQuery.OrderBy(c=>c.SCLIENT).Take(20).ToQueryString();
Check(!clientSql.Contains("INNER JOIN",StringComparison.OrdinalIgnoreCase) && clientSql.Contains("LEFT JOIN",StringComparison.OrdinalIgnoreCase), "CLIENT must preserve rows with missing optional catalogs");
var nullableFields=JsonSerializer.Deserialize<List<NullableField>>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"OracleNullableColumns.json")))!;
var nullability=new NullabilityInfoContext();
foreach(var field in nullableFields)
{
    var type=typeof(APPUSER).Assembly.GetType("WEBVisualTime.Entidades.Insudb."+field.Entity)!;
    Check(model.FindEntityType(type)!.FindProperty(field.Property)!.IsNullable,"Oracle NULL mismatch: "+field.Entity+"."+field.Property);
    foreach(var prefix in new[]{"","Create","Update"})
    {
        var dtoType=typeof(APPUSERDto).Assembly.GetType($"WEBVisualTime.Servicios.Insudb.DTOs.{field.Entity}.{prefix}{field.Entity}Dto")!;
        var property=dtoType.GetProperty(field.Property);
        if(property is null)continue;
        Check(property.PropertyType.IsValueType ? Nullable.GetUnderlyingType(property.PropertyType) is not null : nullability.Create(property).ReadState==NullabilityState.Nullable,"DTO must accept Oracle NULL: "+dtoType.Name+"."+field.Property);
    }
}
var additional=JsonSerializer.Deserialize<List<AdditionalRelationship>>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory,"OracleAdditionalRelationships.json")))!;
foreach(var expectedFk in additional)
{
    var type=typeof(APPUSER).Assembly.GetType("WEBVisualTime.Entidades.Insudb."+expectedFk.Entity)!;
    var fk=model.FindEntityType(type)!.GetForeignKeys().Single(f=>f.PrincipalEntityType.ClrType.Name==expectedFk.Target && f.Properties.Select(p=>p.Name).SequenceEqual(expectedFk.ForeignKeys));
    Check(fk.PrincipalKey.Properties.Select(p=>p.Name).SequenceEqual(expectedFk.PrincipalKeys),"Additional FK principal key order");
    Check(fk.GetConstraintName()==expectedFk.Constraint,"Additional FK must retain Oracle constraint name");
    Check(fk.DeleteBehavior==DeleteBehavior.NoAction && fk.DependentToPrincipal is null,"Additional FK must preserve Oracle deletion rule and avoid automatic joins");
}
foreach(var disabled in new[]{"R_815","R_816","R_2093"})
    Check(!model.GetEntityTypes().SelectMany(e=>e.GetForeignKeys()).Any(f=>f.GetConstraintName()==disabled),"Disabled Oracle constraints must not be introduced into the active model");
foreach(var entityName in new[]{"TABLE8006","TABLE8007"})
    Check(ModelIntegrityRules.ReadOnlyReason(entityName) is not null,"Duplicate identities must be restricted");
var readOnlyRepository=new Repository<TABLE8006>(context);
try { await readOnlyRepository.AddAsync(new TABLE8006()); Check(false,"Unsafe creation must be blocked"); }
catch(InvalidOperationException e) { Check(e.Message.Contains("duplicados"),"Repository must explain why writes are blocked"); }
Check(!context.ChangeTracker.Entries<TABLE8006>().Any(),"Blocked creation must not track a pending insertion");
Check(ListingPolicy.DefaultPageSize==20,"All initial listings must default to 20");
Check(ListingPolicy.NormalizePageSize(50)==50 && ListingPolicy.NormalizePageSize(25)==25,"Page sizes must be configurable");
Check(ListingPolicy.NormalizePageSize(0)==20 && ListingPolicy.NormalizePageSize(101)==20,"Invalid page sizes must use the general default");
var addressEntity=model.FindEntityType(typeof(ADDRESS))!;
var orderedAddress=ListQueryExpressions.OrderByKeys(context.ADDRESSs.AsNoTracking(),addressEntity).Skip(20).Take(ListingPolicy.PageSize).ToQueryString();
var order=orderedAddress[orderedAddress.LastIndexOf("ORDER BY",StringComparison.Ordinal)..];
Check(order.IndexOf("NRECOWNER",StringComparison.Ordinal)<order.IndexOf("SKEYADDRESS",StringComparison.Ordinal) && order.IndexOf("SKEYADDRESS",StringComparison.Ordinal)<order.IndexOf("DEFFECDATE",StringComparison.Ordinal),"Composite ordering must include every primary-key column in order");
Check(orderedAddress.Contains("OFFSET") && orderedAddress.Contains("FETCH NEXT"),"Oracle must perform the actual paging");
string SearchSql(string search)
{
    var filter=ListQueryExpressions.Search<CLIENT>(clientEntity,search)!;
    return ListQueryExpressions.OrderByKeys(context.CLIENTs.AsNoTracking().Where(filter),clientEntity).Take(20).ToQueryString();
}
var firstText=SearchSql("ABCDE");var secondText=SearchSql("XYZ");
// Oracle ToQueryString returns a runnable PL/SQL script with separate bind_variable calls.
// Compare the actual l_sql text, not the debugging script's bound-value declarations.
string Statement(string script)
{
    var match=Regex.Match(script,@"l_sql\s*:=\s*'(?<sql>(?:''|[^'])*)';",RegexOptions.Singleline);
    return match.Success ? match.Groups["sql"].Value : script[script.IndexOf("SELECT ",StringComparison.Ordinal)..];
}
var firstBody=Statement(firstText);
var secondBody=Statement(secondText);
if (firstBody!=secondBody || firstBody.Contains("ABCDE"))
{
    File.WriteAllText(Path.Combine(AppContext.BaseDirectory,"search-sql-first.sql"),firstText);
    File.WriteAllText(Path.Combine(AppContext.BaseDirectory,"search-sql-second.sql"),secondText);
}
Check(firstBody==secondBody && !firstBody.Contains("ABCDE"),"Search values must be parameterized rather than embedded into SQL");
Check(SearchSql("2026-11-06").Contains("DCOMPDATE"),"Date search must translate to Oracle SQL");
Check(SearchSql("7").Contains("NUSERCODE"),"Numeric search must translate to Oracle SQL");
var bankFilter=ListQueryExpressions.Search<BANK_ACC>(model.FindEntityType(typeof(BANK_ACC))!,"ABCDE")!;
Check(context.BANK_ACCs.Where(bankFilter).Take(20).ToQueryString().Contains("TAB_BK_AGE"),"Search through composite-key catalog relationships must translate");
Check(Statement(SearchSql("NaN"))==firstBody,"Non-finite numeric input must stay a text search");
void CheckExcludedField<T>(string field) where T:class
{
    var type=model.FindEntityType(typeof(T))!;
    Check(type.FindProperty(field)!.FindAnnotation("Listing:Searchable")?.Value is false,"Unsupported Oracle text field must be configured explicitly");
    var filter=ListQueryExpressions.Search<T>(type,"ABCDE")!;
    var query=Statement(context.Set<T>().Where(filter).Take(20).ToQueryString());
    var where=query[query.IndexOf("WHERE ",StringComparison.Ordinal)..];
    Check(!where.Contains('"'+field+'"'),"Generic search must not invoke UPPER on special Oracle storage types");
}
CheckExcludedField<HEALTHCLAIMFORM>("CONTENT");
CheckExcludedField<MASTERSHEET>("SQUERY_XSL");
CheckExcludedField<TRACKING>("FACTTIME");
Console.WriteLine($"PASS: {checks} assertions; {model.GetEntityTypes().Count()} entities; {expected.Count} Oracle-confirmed composite relationships; compatible FK types, no implicit FK columns, aliases and SQL generation. No database connection.");

sealed record ExpectedRelationship(string Entity,string Target,string Navigation,string[] ForeignKeys,string[] PrincipalKeys,string Constraint,string[] Aliases);
sealed record NullableField(string Entity,string Property,string Column);
sealed record AdditionalRelationship(string Entity,string Target,string[] ForeignKeys,string[] PrincipalKeys,string Constraint);
