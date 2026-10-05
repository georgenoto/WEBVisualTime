namespace WEBVisualTime.Servicios.Insudb.DTOs.CHEQ_BOOK;

public class UpdateCHEQ_BOOKDto
{
    public int NACC_BANK { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SCHEQUE_END { get; set; }
    public string? SCHEQUE_LAS { get; set; }
    public string? SCHEQUE_STA { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NQ_CHE_DAMA { get; set; }
    public int? NQ_CHE_NULL { get; set; }
    public int? NUSERCODE { get; set; }
}
