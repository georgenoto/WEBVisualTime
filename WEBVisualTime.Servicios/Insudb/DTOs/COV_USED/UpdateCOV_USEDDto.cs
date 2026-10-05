namespace WEBVisualTime.Servicios.Insudb.DTOs.COV_USED;

public class UpdateCOV_USEDDto
{
    public long NCLAIM { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public int NGROUP_INSU { get; set; }
    public int NTRANSAC { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NCURRENCY { get; set; }
    public string SCLIENT { get; set; }
    public long NSTARTDATE { get; set; }
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCON_ID { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime? DRESTIT_DAT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPURPOSE { get; set; }
}
