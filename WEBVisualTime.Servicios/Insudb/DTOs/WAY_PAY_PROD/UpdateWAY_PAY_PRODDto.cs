namespace WEBVisualTime.Servicios.Insudb.DTOs.WAY_PAY_PROD;

public class UpdateWAY_PAY_PRODDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NWAY_PAY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NRATE_EX { get; set; }
    public decimal? NRATE_DISC { get; set; }
    public string SPREM_FIRST { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NNULL_DAY { get; set; }
    public string? SIND_PREISSU { get; set; }
    public string? SIND_PREREF { get; set; }
    public string? SONERECEIPT { get; set; }
    public string? SLASTRECEIPT { get; set; }
    public string? SCOLLECTION { get; set; }
    public string? SIND_PREREFMAX { get; set; }
    public string? SPRFIRST_EXPR { get; set; }
    public int NTYPE_VALUECOLLECT { get; set; }
}
