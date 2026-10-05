#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TDETAIL_PRE
{
    public string? SKEY { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NBILL_ITEM { get; set; }
    public int? NBRANCH_EST { get; set; }
    public int? NBRANCH_LED { get; set; }
    public int? NBRANCH_REI { get; set; }
    public string? SADDSUINI { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCODE { get; set; }
    public decimal? NCOMMI_RATE { get; set; }
    public decimal? NCOMMISION { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NCAPI_INI { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NPREMIUM_AN { get; set; }
    public string? STYPE_DETAI { get; set; }
    public decimal? NP_NOTCONS { get; set; }
    public decimal? NP_OUTSTAND { get; set; }
    public decimal? NP_ADJUST { get; set; }
    public decimal? NPREM_INI { get; set; }
    public decimal? NPREM_ACT { get; set; }
    public decimal? NCOMMI_ANU { get; set; }
    public string? SADDTAX { get; set; }
    public int? NID_BILL { get; set; }
    public int? NREL_IDBILL { get; set; }
    public string? SCLIENT { get; set; }
    public int? NROLE { get; set; }
    public decimal? NTAXIVA { get; set; }
    public long? NINSURED { get; set; }
    public int? NGROUP { get; set; }
    public long? NINSUCOUNT { get; set; }
    public decimal? NTAXMAR { get; set; }
    public decimal? NAMOUNTIVA { get; set; }
    public decimal? NTAXTARIF { get; set; }
    public decimal? NPREMIUMA { get; set; }
    public decimal? NPREMIUME { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SCACALILI { get; set; }
    public string? SCOMMISSI_I { get; set; }
    public string? SADDTAXIN { get; set; }
    public int? NTYPDURINS { get; set; }
    public int? NTYPDURPAY { get; set; }
    public decimal? NCOM_NOTCONS { get; set; }
    public decimal? NCOM_OUTSTAND { get; set; }
    public int? NPREM_DET { get; set; }
    public string? SPREM_DET { get; set; }
    public int? NREL_IDCODE { get; set; }
    public decimal? NTAXRATE { get; set; }
    public int NDISSUR_TYPE { get; set; }

    [ForeignKey("NDISSUR_TYPE")]
    public Insudb.TABLE9207? TABLE9207 { get; set; }
    public decimal? NCOM_SUPER { get; set; }
    public decimal? NCOMANUAL_SUPER { get; set; }
    public decimal? NCOMSUP_RATE { get; set; }
}
