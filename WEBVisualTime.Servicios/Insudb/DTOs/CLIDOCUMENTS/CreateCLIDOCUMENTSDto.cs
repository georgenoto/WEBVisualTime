namespace WEBVisualTime.Servicios.Insudb.DTOs.CLIDOCUMENTS;

public class CreateCLIDOCUMENTSDto
{
    public DateTime? DISSUEDAT { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NCLASSTYPDOC { get; set; }
    public int? NTYPEXP { get; set; }
    public string? SIDCOMPL { get; set; }
}
