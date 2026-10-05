#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class STIPEND_POL
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
    public int NROLE { get; set; }
    public string SCLIENT { get; set; }
    public int NTYPE_CONTRAT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCOMMITYP { get; set; }

    [ForeignKey("SCOMMITYP")]
    public Insudb.TABLE47? TABLE47 { get; set; }
    public long? NCONTRAT_PAY { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
}
