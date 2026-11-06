#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COV_USED
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASENCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [NotMapped]
    public Insudb.CLAIM_CASE? CLAIM_CASENCASE_NUM
    {
        get => CLAIM_CASENCLAIM;
        set => CLAIM_CASENCLAIM = value;
    }
    public int NDEMAN_TYPE { get; set; }

    [NotMapped]
    public Insudb.CLAIM_CASE? CLAIM_CASENDEMAN_TYPE
    {
        get => CLAIM_CASENCLAIM;
        set => CLAIM_CASENCLAIM = value;
    }
    public int NGROUP_INSU { get; set; }
    public int NTRANSAC { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NCURRENCY { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public long NSTARTDATE { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public decimal? NCAPITAL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCON_ID { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime? DRESTIT_DAT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SPURPOSE { get; set; }
}
