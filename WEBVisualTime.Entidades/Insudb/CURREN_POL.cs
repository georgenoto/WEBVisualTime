#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CURREN_POL
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
    public int NCURRENCY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
