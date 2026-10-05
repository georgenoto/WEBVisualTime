#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAUSE
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
    public int NCLAUSE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NID { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCLIENT { get; set; }
    public int? NGROUP_INSU { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public int? NCAUSE { get; set; }
    public string SAGREE { get; set; }
    public string? STYPE_CLAUSE { get; set; }
    public string? SDOC_ATTACH { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
