namespace WEBVisualTime.Servicios.Insudb.DTOs.CURR_ACC;

public class CreateCURR_ACCDto
{
    public decimal? NBALANCE { get; set; }
    public decimal? NCREDIT { get; set; }
    public decimal? NDEBIT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NLED_COMPAN { get; set; }
    public string? SACCOUNT { get; set; }
    public string? SCERTYPE { get; set; }
    public int? NCOMPANY { get; set; }
    public int? NPRODUCT { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public int? NBRANCH { get; set; }
    public long? NCERTIF { get; set; }
    public long? NPOLICY { get; set; }
    public int? NINSUR_AREA { get; set; }
}
