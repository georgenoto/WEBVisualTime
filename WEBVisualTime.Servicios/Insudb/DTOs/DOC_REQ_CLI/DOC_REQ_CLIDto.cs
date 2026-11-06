namespace WEBVisualTime.Servicios.Insudb.DTOs.DOC_REQ_CLI;

public class DOC_REQ_CLIDto
{
    public long NEVAL { get; set; }
    public string? EVAL_MASTERSCERTYPE { get; set; }
    public long NID { get; set; }
    public int? NTYPEDOC { get; set; }
    public string? TABLE32SDESCRIPT { get; set; }
    public int NSTATUSDOC { get; set; }
    public string? TABLE275SDESCRIPT { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime DDOCREQ { get; set; }
    public DateTime? DDOCREC { get; set; }
    public DateTime DDOCDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal NCAPITAL { get; set; }
    public long? NNOTENUM { get; set; }
    public int NUSERCODE { get; set; }
    public string? USERSSACCESSWO { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DDATETO { get; set; }
    public DateTime? DDATEFREE { get; set; }
    public string? SREQUEST { get; set; }
}
