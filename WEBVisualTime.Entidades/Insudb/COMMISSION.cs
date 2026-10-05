#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMISSION
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
    public int NINTERTYP { get; set; }

    [ForeignKey("NINTERTYP")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public string? SCOMMITYP { get; set; }

    [ForeignKey("SCOMMITYP")]
    public Insudb.TABLE47? TABLE47 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NPERDISCOUNT { get; set; }
    public string? SPLUSCOLLEC { get; set; }
    public string? SPLUSOFFICE { get; set; }
    public string? SPLUSQUALITY { get; set; }
    public int? NAGREEMENT { get; set; }
    public decimal? NPERCENT_CE { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public int? NINSTALLCOM { get; set; }
    public int? NCATEGORY { get; set; }
    public int NID_CAMPAIGN { get; set; }
    public DateTime? DDATEEND_CAMP { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
