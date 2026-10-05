namespace WEBVisualTime.Servicios.Insudb.DTOs.ROLDOCREQ;

public class ROLDOCREQDto
{
    public int NBRANCH { get; set; }
    public string? CLIALLOPRONBRANCHSDEFAULTI { get; set; }
    public int NPRODUCT { get; set; }
    public string? CLIALLOPRONPRODUCTSDEFAULTI { get; set; }
    public string SPOLITYPE { get; set; }
    public string? CLIALLOPROSPOLITYPESDEFAULTI { get; set; }
    public string SCOMPON { get; set; }
    public string? CLIALLOPROSCOMPONSDEFAULTI { get; set; }
    public int NROLE { get; set; }
    public string? CLIALLOPRONROLESDEFAULTI { get; set; }
    public int NCLASSTYPDOC { get; set; }
    public string? FORMATVALUESNCLASSTYPDOCSDESCRIPT { get; set; }
    public int NTYPCLIENTDOC { get; set; }
    public string? FORMATVALUESNTYPCLIENTDOCSDESCRIPT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
