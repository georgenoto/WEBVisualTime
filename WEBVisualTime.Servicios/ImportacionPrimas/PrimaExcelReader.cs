using System.Globalization;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using WEBVisualTime.Entidades.ImportacionPrimas;

namespace WEBVisualTime.Servicios.ImportacionPrimas;

// Reads only OpenXML values. VBA, links and formulas are never executed.
public sealed class PrimaExcelReader
{
    public const int MaxBytes = 20 * 1024 * 1024;
    public const int MaxRows = 100_000;
    static readonly XNamespace X = "http://schemas.openxmlformats.org/spreadsheetml/2006/main";
    static readonly string[] Headers = ["Ramo", "Descripcion", "Producto", "Fecha de efecto", "Modulo", "Cobertura",
        "Tipo Asegurado", "Regional", "Ambito geografico", "Sistema de atencion", "Capital", "Moneda", "minima", "Maxima",
        "Masculino", "Femenino", "Ano de poliza inicial", "Ano de poliza final"];
    static XDocument Xml(ZipArchiveEntry entry)
    {
        using var stream = entry.Open();
        using var reader = XmlReader.Create(stream, new XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit, XmlResolver = null, MaxCharactersInDocument = 100_000_000 });
        return XDocument.Load(reader);
    }
    static string Normal(string s) => Regex.Replace(string.Concat(s.Normalize(NormalizationForm.FormD)
        .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)), @"\s+", " ").Trim().ToUpperInvariant();
    public PrimaDocumento Leer(byte[] bytes, string archivo)
    {
        if (bytes.Length == 0 || bytes.Length > MaxBytes) throw new ArgumentException("El archivo debe tener entre 1 byte y 20 MB.");
        if (!new[] { ".xlsx", ".xlsm" }.Contains(Path.GetExtension(archivo).ToLowerInvariant())) throw new ArgumentException("Utilice un archivo .xlsx o .xlsm.");
        using var zip = new ZipArchive(new MemoryStream(bytes), ZipArchiveMode.Read);
        if (zip.Entries.Sum(e => e.Length) > 150L * 1024 * 1024) throw new ArgumentException("El archivo descomprimido supera 150 MB.");
        var wb = Xml(zip.GetEntry("xl/workbook.xml") ?? throw new ArgumentException("Libro Excel inválido."));
        var sheets = wb.Descendants(X + "sheet").ToList();
        var sheet = sheets.FirstOrDefault(e => (string?)e.Attribute("name") == "DATOS") ?? sheets.FirstOrDefault()
            ?? throw new ArgumentException("No hay hojas para importar.");
        var rid = (string?)sheet.Attribute(XNamespace.Get("http://schemas.openxmlformats.org/officeDocument/2006/relationships") + "id");
        var rel = Xml(zip.GetEntry("xl/_rels/workbook.xml.rels")!).Root!.Elements().Single(e => (string?)e.Attribute("Id") == rid);
        var target = (string)rel.Attribute("Target")!;
        var path = target.StartsWith('/') ? target.TrimStart('/') : "xl/" + target;
        var shared = zip.GetEntry("xl/sharedStrings.xml") is { } ss
            ? Xml(ss).Descendants(X + "si").Select(e => string.Concat(e.Descendants(X + "t").Select(t => t.Value))).ToArray() : [];
        var data = Xml(zip.GetEntry(path) ?? throw new ArgumentException("No se encuentra la hoja de entrada."));
        var date1904 = new[] { "1", "true" }.Contains((string?)wb.Root?.Element(X + "workbookPr")?.Attribute("date1904"));
        var result = new List<PrimaFila>(); var headerFound = false; var errors = new List<string>();
        foreach (var row in data.Descendants(X + "sheetData").Elements(X + "row"))
        {
            var n = (int?)row.Attribute("r") ?? 0;
            var cells = row.Elements(X + "c").Where(c => Regex.IsMatch((string?)c.Attribute("r") ?? "", @"^[A-R]\d+$"))
                .ToDictionary(c => ((string)c.Attribute("r")!)[0], c => c);
            string Get(char col)
            {
                if (!cells.TryGetValue(col, out var c)) return "";
                var type = (string?)c.Attribute("t"); var value = c.Element(X + "v")?.Value ?? "";
                if (type == "s") return shared[int.Parse(value, CultureInfo.InvariantCulture)].Replace('\u00a0', ' ').Trim();
                if (type == "inlineStr") return string.Concat(c.Descendants(X + "t").Select(t => t.Value)).Replace('\u00a0', ' ').Trim();
                return value.Replace('\u00a0', ' ').Trim();
            }
            var vals = Enumerable.Range('A', 18).Select(c => Get((char)c)).ToArray();
            if (!headerFound)
            {
                if (Normal(vals[0]) != "RAMO") continue;
                if (!vals.Select(Normal).SequenceEqual(Headers.Select(Normal))) throw new ArgumentException("Los encabezados A:R no coinciden con las 18 columnas de la plantilla.");
                headerFound = true; continue;
            }
            if (vals.All(string.IsNullOrWhiteSpace)) continue;
            if (result.Count >= MaxRows) throw new ArgumentException("Máximo 100.000 filas de entrada.");
            try
            {
                if (cells.Values.Any(c => c.Element(X + "f") != null || (string?)c.Attribute("t") is "e" or "b")) throw new ArgumentException("No se admiten fórmulas, booleanos ni errores de Excel en A:R.");
                int Code(char col)
                {
                    var m = Regex.Match(Get(col), @"^([0-9]+)(?:[ \t-].*)?$");
                    if (!m.Success || !int.TryParse(m.Groups[1].Value, out var value)) throw new ArgumentException($"{col}: código inicial inválido.");
                    return value;
                }
                decimal? Number(char col, bool optional = false)
                {
                    var text = Get(col);
                    if (optional && text == "") return null;
                    // OpenXML numeric cells always use '.', regardless of workstation locale.
                    if (!decimal.TryParse(text, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowExponent,
                        CultureInfo.InvariantCulture, out var v) || v < 0) throw new ArgumentException($"{col}: número no negativo inválido (use punto decimal, sin miles).");
                    // Excel promises 15 significant digits; eliminate binary serialization tails
                    // such as 1718.6402999999999, matching the value displayed/used by VBA.
                    if (cells.TryGetValue(col, out var numericCell) && (string?)numericCell.Attribute("t") is null or "n")
                        v = decimal.Parse(double.Parse(text, CultureInfo.InvariantCulture).ToString("G15", CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);
                    return v;
                }
                int Integer(char col)
                {
                    var v = Number(col)!.Value;
                    if (v > int.MaxValue || decimal.Truncate(v) != v) throw new ArgumentException($"{col}: se requiere entero.");
                    return (int)v;
                }
                DateTime effect;
                if (cells.TryGetValue('D', out var dc) && ((string?)dc.Attribute("t") is null or "n"))
                {
                    if (!double.TryParse(Get('D'), NumberStyles.Float, CultureInfo.InvariantCulture, out var serial)) throw new ArgumentException("D: fecha inválida.");
                    effect = DateTime.FromOADate(serial + (date1904 ? 1462 : 0)).Date;
                }
                else if (!DateTime.TryParseExact(Get('D'), ["dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd", "yyyy-MM-ddTHH:mm:ss"], CultureInfo.InvariantCulture, DateTimeStyles.None, out effect)) throw new ArgumentException("D: fecha inválida.");
                if (effect.Year < 1900 || effect.Year > 2200) throw new ArgumentException("D: fecha fuera de rango 1900–2200.");
                var min = Integer('M'); var max = Get('N') == "" ? min : Integer('N');
                var start = Integer('Q'); var end = Integer('R');
                var capital = Number('K', true) ?? 0;
                if (min > max || start > end || capital > 9999999) throw new ArgumentException("Rangos de edad, año o capital incoherentes.");
                var male = Number('O', true); var female = Number('P', true);
                if (male is null && female is null) throw new ArgumentException("Falta prima masculina y femenina.");
                result.Add(new(n, Get('B'), Code('A'), Integer('C'), effect.Date, Integer('E'), Code('F'), Code('G'), Code('H'), Code('I'), Code('J'), capital, Code('L'), min, max, male, female, start, end));
            }
            catch (Exception ex) when (ex is ArgumentException or OverflowException)
            { errors.Add($"Fila {n}: {ex.Message}"); if (errors.Count >= 50) break; }
        }
        if (!headerFound) throw new ArgumentException("No se encontraron encabezados de la plantilla en la hoja de entrada.");
        if (errors.Count > 0) throw new ArgumentException(string.Join("\n", errors));
        if (result.Count == 0) throw new ArgumentException("No hay registros de entrada.");
        return new(Path.GetFileName(archivo), Convert.ToHexString(SHA256.HashData(bytes)), result);
    }
    public static void ValidarPlan(PrimaPlan plan)
    {
        if (plan.FechaEfecto is DateTime effect && (effect.Year < 1900 || effect.Year > 2200 || effect != effect.Date))
            throw new ArgumentException("La fecha de efecto debe ser una fecha sin hora entre 1900 y 2200.");
        if (plan.Roles.Length == 0 || plan.Regionales.Length == 0 || plan.Usuario <= 0) throw new ArgumentException("Seleccione al menos un rol, una regional y un usuario Oracle válido.");
        if (plan.Roles.Distinct().Count() != plan.Roles.Length || plan.Regionales.Distinct().Count() != plan.Regionales.Length) throw new ArgumentException("Selección duplicada.");
        if (plan.Total > 5_000_000) throw new ArgumentException("La expansión supera 5.000.000 de registros. Divida el archivo.");
        // Original role/office are intentionally excluded: the selection replaces both.
        var duplicates = plan.Documento.Filas.GroupBy(f => new { f.Ramo, f.Producto, Efecto = plan.FechaEfecto ?? f.Efecto, f.Modulo, f.Cobertura, f.Ambito, f.Atencion, f.Capital, f.Moneda, f.EdadDesde, f.EdadHasta, f.AnioDesde, f.AnioHasta }).FirstOrDefault(g => g.Count() > 1);
        if (duplicates != null) throw new ArgumentException("La expansión produciría claves repetidas. Filas de origen: " + string.Join(", ", duplicates.Take(10).Select(f => f.Fila)));
        long comparisons = 0;
        foreach (var group in plan.Documento.Filas.GroupBy(f => new { f.Ramo, f.Producto, f.Modulo, f.Cobertura, f.Ambito, f.Atencion, f.Moneda }))
        {
            var rows = group.OrderBy(f => f.EdadDesde).ToArray();
            for (var i = 0; i < rows.Length; i++)
            for (var j = i + 1; j < rows.Length && rows[j].EdadDesde <= rows[i].EdadHasta; j++)
            {
                if (++comparisons > 2_000_000) throw new ArgumentException("Hay demasiadas combinaciones de rangos para revisar en una importación. Divida el archivo por módulo o cobertura.");
                // All imports have open-ended validity and the same maximum capital.
                if (rows[j].AnioDesde <= rows[i].AnioHasta && rows[i].AnioDesde <= rows[j].AnioHasta)
                    throw new ArgumentException($"Rangos superpuestos entre filas {rows[i].Fila} y {rows[j].Fila}. Separe o corrija las tarifas antes de continuar.");
            }
        }
    }
}
