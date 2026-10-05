#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LIFE_DOCU
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NMODULEC { get; set; }
    public int NCRTHECNI { get; set; }
    public int NCOVER { get; set; }
    public DateTime? DRECEP_DATE { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public int NSTAT_DOCREQ { get; set; }

    [ForeignKey("NSTAT_DOCREQ")]
    public Insudb.TABLE275? TABLE275 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DDATE_TO { get; set; }
    public DateTime? DDATEFREE { get; set; }
    public long NEVAL { get; set; }

    [ForeignKey("NEVAL")]
    public Insudb.EVAL_MASTER? EVAL_MASTER { get; set; }
    public DateTime? DDATEVIG { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SREQUEST { get; set; }
    public int NREASON { get; set; }

    [ForeignKey("NREASON")]
    public Insudb.TABLE5719? TABLE5719 { get; set; }
    public string? SRANDOM { get; set; }
    public long? NID_SECUENCIA { get; set; }
}
