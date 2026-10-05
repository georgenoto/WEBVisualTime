namespace WEBVisualTime.Servicios.Insudb.DTOs.LIMITS;

public class CreateLIMITSDto
{
    public decimal? NCLAIM_D { get; set; }
    public decimal? NCLAIM_P { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NISSUELIM { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
