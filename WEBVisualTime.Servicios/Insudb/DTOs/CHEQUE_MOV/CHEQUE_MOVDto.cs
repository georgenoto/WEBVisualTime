namespace WEBVisualTime.Servicios.Insudb.DTOs.CHEQUE_MOV;

public class CHEQUE_MOVDto
{
    public int NCOMPANY { get; set; }
    public string? COMPANYSACCOUNT { get; set; }
    public long NBANK_CODE { get; set; }
    public string? TABLE7NBANK_CODESDESCRIPT { get; set; }
    public string SCHEQUENU { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NCHEOPERTYP { get; set; }
    public int? NCHEOPER_REASON { get; set; }
    public string? TABLE5577SDESCRIPT { get; set; }
    public int NID { get; set; }
    public long? NBANK_INTER { get; set; }
    public string? TABLE7NBANK_INTERSDESCRIPT { get; set; }
    public string? SCHEQUEINTER { get; set; }
    public DateTime? DNEW_DATE { get; set; }
    public string? SDEPNUMBER { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NFIN_INT { get; set; }
    public long? NNOTENUM { get; set; }
}
