#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MEDICAL_EVAL_ROL
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.ROLES? ROLESSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.ROLES? ROLESNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.ROLES? ROLESNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.ROLES? ROLESNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.ROLES? ROLESNCERTIF { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.ROLES? ROLESNROLE { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.ROLES? ROLESSCLIENT { get; set; }
    public int NMEDICALSTAT { get; set; }

    [ForeignKey("NMEDICALSTAT")]
    public Insudb.TABLE9216? TABLE9216 { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }

    [ForeignKey("DEFFECDATE")]
    public Insudb.ROLES? ROLESDEFFECDATE { get; set; }
    public int? NMONTHS { get; set; }
}
