namespace WEBVisualTime.Servicios.Insudb.DTOs.CHEQUE_MOV;

public class CreateCHEQUE_MOVDto
{
    public int? NCHEOPER_REASON { get; set; }
    public long? NBANK_INTER { get; set; }
    public string? SCHEQUEINTER { get; set; }
    public DateTime? DNEW_DATE { get; set; }
    public string? SDEPNUMBER { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NFIN_INT { get; set; }
    public long? NNOTENUM { get; set; }
}
