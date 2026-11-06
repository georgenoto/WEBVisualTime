#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class INSURED_EXPDIS
{
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
    public int NGROUP_INSU { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NDISEXPRC { get; set; }
    public string SDISEXPRI { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SUNIT { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string SPERM_TEMP { get; set; }
    public DateTime? DDATE_FR { get; set; }
    public DateTime? DDATE_TO { get; set; }
    public int? NAGE { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int? NCAUSE { get; set; }
    public string SAGREE { get; set; }
    public string? SINITDATE_CALC { get; set; }
    public long? NACTIVITY { get; set; }
    public long? NSPORT { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
