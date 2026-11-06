#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DISC_XPREM
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
    public int NDISC_CODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NCAUSE { get; set; }

    [ForeignKey("NCAUSE")]
    public Insudb.TABLE5631? TABLE5631 { get; set; }
    public string SAGREE { get; set; }
    public decimal? NPERCENT { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
