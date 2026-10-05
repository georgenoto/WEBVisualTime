namespace WEBVisualTime.Servicios.Insudb.DTOs.COVER_QUOTA;

public class UpdateCOVER_QUOTADto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public int NGROUP { get; set; }
    public int NMODULEC { get; set; }
    public int NROLE { get; set; }
    public int NCOVER { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NTAXIVA { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long? NINSUCOUNT { get; set; }
    public long? NINSURED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NCERTIF { get; set; }
}
