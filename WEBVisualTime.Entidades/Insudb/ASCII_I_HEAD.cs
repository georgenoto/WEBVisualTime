#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ASCII_I_HEAD
{
    public string SASCII_NAME { get; set; }
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE293? TABLE293 { get; set; }
    public DateTime DSTAT_DATE { get; set; }
    public string SACC_NUMBER { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string? SSTATMOV { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE193? TABLE193 { get; set; }
}
