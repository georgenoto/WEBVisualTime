#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MODULES
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
    public int NMODULEC { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCHANGEI { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NPREMIRAT { get; set; }
    public string? STYP_RAT { get; set; }
    public string? SINHERIT { get; set; }
    public int? NGEOGRAPHAREA { get; set; }

    [ForeignKey("NGEOGRAPHAREA")]
    public Insudb.TABLE9214? TABLE9214 { get; set; }
    public int? NATTENSYSTEM { get; set; }

    [ForeignKey("NATTENSYSTEM")]
    public Insudb.TABLE9215? TABLE9215 { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
