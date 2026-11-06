namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_VOUCHER;

public class UpdateCLAIM_VOUCHERDto
{
    public long NCLAIM_VOUCHER { get; set; }
    public int NTYPEDOC_PAY { get; set; }
    public string? SCLINUMDOCU { get; set; }
    public DateTime DISSUEDAT { get; set; }
    public string? SELECTRONIC_DOC { get; set; }
    public string? SSENDER_NAME { get; set; }
    public string? SCUF_NUMBER { get; set; }
    public string? SVOUCHER_SERIES { get; set; }
    public long? NVOUCHER_NUM { get; set; }
    public string? SCONTROL_CODE { get; set; }
    public int? NSTATUS { get; set; }
    public string? SOBSERV { get; set; }
    public decimal? NAMOUNT_DOCU { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public decimal? NBALANCE { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NFOREIGNDOCTYPE { get; set; }
    public int? NPROVIDER { get; set; }
    public string? SCLIENT { get; set; }
    public long? NNOTENUM { get; set; }
    public long? NSEQUENCE_ID { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public long? NCODIGINT { get; set; }
    public decimal? NAMOUNT_VAT { get; set; }
    public decimal? NAMOUNT_FTT { get; set; }
    public decimal? NAMOUNT_VAT_RATE { get; set; }
    public decimal? NAMOUNT_FTT_RATE { get; set; }
    public decimal? NAMOUNT_BASE { get; set; }
}
