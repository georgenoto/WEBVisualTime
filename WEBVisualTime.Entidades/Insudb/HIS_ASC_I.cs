#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class HIS_ASC_I
{
    public int NID { get; set; }
    public string SASCII_NAME { get; set; }

    [ForeignKey("SASCII_NAME")]
    public Insudb.ASCII_I_HEAD? ASCII_I_HEAD { get; set; }
    public string SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE182? TABLE182 { get; set; }
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7NBANK_CODE { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE293? TABLE293 { get; set; }
    public DateTime DSTAT_DATE { get; set; }
    public string SACC_NUMBER { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string SCLIENT { get; set; }
    public string SACCOUNTHOLDER { get; set; }
    public long NREQUEST_NU { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public string SBANKACCOUNT { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7NBANKEXT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
