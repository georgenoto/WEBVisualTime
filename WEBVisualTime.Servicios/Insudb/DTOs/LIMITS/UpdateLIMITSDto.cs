namespace WEBVisualTime.Servicios.Insudb.DTOs.LIMITS;

public class UpdateLIMITSDto
{
    public string SSCHE_CODE { get; set; }
    public int NCURRENCY { get; set; }
    public int NBRANCH { get; set; }
    public decimal? NCLAIM_D { get; set; }
    public int NPRODUCT { get; set; }
    public decimal? NCLAIM_P { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NISSUELIM { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
