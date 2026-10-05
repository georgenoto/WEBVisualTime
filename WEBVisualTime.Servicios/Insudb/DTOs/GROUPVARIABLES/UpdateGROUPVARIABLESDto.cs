namespace WEBVisualTime.Servicios.Insudb.DTOs.GROUPVARIABLES;

public class UpdateGROUPVARIABLESDto
{
    public int NLETT_GROUP { get; set; }
    public string SVARIABLE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? STABLENAME { get; set; }
    public string? SCOLUMNAME { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTYPVARIABLE { get; set; }
    public string? STABVALUE { get; set; }
    public string? SALIASTABLE { get; set; }
    public string? SALIASCOLUMN { get; set; }
}
