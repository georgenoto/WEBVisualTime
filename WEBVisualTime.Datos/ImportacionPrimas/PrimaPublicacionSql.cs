namespace WEBVisualTime.Datos.ImportacionPrimas;

// All duplicate checks use the physical primary key. Renewal scope is independent
// of age, capital and policy-year bands, which may change in a new tariff version.
public static class PrimaPublicacionSql
{
    public const string Columns = "NBRANCH,NPRODUCT,DEFFECDATE,NROLE,NMODULEC,NCOVER,NGEOGRAPHAREA,NATTENSYSTEM,NOFFICE,NCAPITAL_INIT,NCAPITAL_END,NPOLICY_YEAR_INIT,NPOLICY_YEAR_END,NCURRENCY,NAGE_INIT,NAGE_END,NAMOUNTF,NAMOUNTM,DNULLDATE,DCOMPDATE,NUSERCODE";
    public static readonly string[] Keys = Columns.Split(',').Take(16).ToArray();
    public static string Match => string.Join(" AND ", Keys.Select(k => $"t.{k}=s.{k}"));
    public static string Scope => string.Join(" AND ", Keys.Where(k => !new[] { "DEFFECDATE", "NCAPITAL_INIT", "NCAPITAL_END", "NPOLICY_YEAR_INIT", "NPOLICY_YEAR_END", "NAGE_INIT", "NAGE_END" }.Contains(k)).Select(k => $"t.{k}=s.{k}"));
    public static string Close(string stage) => $"UPDATE INSUDB.TAR_HEALT_PREM t SET DNULLDATE=:fecha WHERE t.DEFFECDATE<:fecha AND (t.DNULLDATE IS NULL OR t.DNULLDATE>:fecha) AND EXISTS(SELECT 1 FROM {stage} s WHERE s.IMPORT_ID=:id AND {Scope})";
    public static string Existing(string stage) => $"SELECT COUNT(*) FROM {stage} s WHERE s.IMPORT_ID=:id AND EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})";
    public static string MarkExisting(string stage) => $"UPDATE {stage} s SET RESULTADO='EXISTENTE' WHERE s.IMPORT_ID=:id AND EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})";
    public static string Insert(string stage)
    {
        var selected=string.Join(',',Columns.Split(',').Select(k=>k=="DCOMPDATE"?"SYSDATE":"s."+k));
        return $"INSERT INTO INSUDB.TAR_HEALT_PREM({Columns}) SELECT {selected} FROM {stage} s WHERE s.IMPORT_ID=:id AND NOT EXISTS(SELECT 1 FROM INSUDB.TAR_HEALT_PREM t WHERE {Match})";
    }
}
