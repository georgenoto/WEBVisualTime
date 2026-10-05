namespace WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;

public class CreateCOV_USEDDto
{
    public int NGROUP_INSU { get; set; }
    public long NSTARTDATE { get; set; }
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime? DRESTIT_DAT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPURPOSE { get; set; }
}
