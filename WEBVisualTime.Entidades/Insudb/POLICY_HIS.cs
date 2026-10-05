#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class POLICY_HIS
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public long NMOVEMENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public string? SNULL_MOVE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public long? NRECEIPT { get; set; }
    public int? NTRANSACTIO { get; set; }
    public int NTYPE_HIST { get; set; }

    [ForeignKey("NTYPE_HIST")]
    public Insudb.TABLE165? TABLE165 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NOFICIAL_P { get; set; }
    public int? NTYPE_AMEND { get; set; }
    public long NSERV_ORDER { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SINTERMEI { get; set; }
    public DateTime? DFER { get; set; }
    public long? NPROPONUM { get; set; }
    public int? NAGENCY { get; set; }
    public int NWAIT_CODE { get; set; }

    [ForeignKey("NWAIT_CODE")]
    public Insudb.TAB_WAITPO? TAB_WAITPO { get; set; }
    public int NSTATQUOTA { get; set; }

    [ForeignKey("NSTATQUOTA")]
    public Insudb.TABLE5526? TABLE5526 { get; set; }
    public int NNO_CONVERS { get; set; }

    [ForeignKey("NNO_CONVERS")]
    public Insudb.NOCONVERS? NOCONVERS { get; set; }
    public int? NCARTPOL { get; set; }
    public int? NNUMCART { get; set; }
    public long? NPOLREF { get; set; }
    public long? NCERREF { get; set; }
    public int? NPAYFREQ { get; set; }
    public int? NNULLCODE { get; set; }
    public string? SFILE_REPORT { get; set; }
    public string? SPROCESS_NUM { get; set; }
    public DateTime? DSTARPROCESS { get; set; }
    public DateTime? DENDPROCESS { get; set; }
    public string? SIND_TRANFER { get; set; }
    public string? SKEY { get; set; }
    public int? NSYSTEM { get; set; }
    public string? SLOT { get; set; }
    public int? NWAY_PAY { get; set; }
    public int? NBILL_DAY { get; set; }
    public int NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public long? NNUMCERT { get; set; }
}
