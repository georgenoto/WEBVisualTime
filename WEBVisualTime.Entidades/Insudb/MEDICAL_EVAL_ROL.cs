#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MEDICAL_EVAL_ROL
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF, NROLE, SCLIENT, DEFFECDATE")]
    public Insudb.ROLES? ROLESSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESNBRANCH
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESNPRODUCT
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESNPOLICY
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESNCERTIF
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public int NROLE { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESNROLE
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public string SCLIENT { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESSCLIENT
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public int NMEDICALSTAT { get; set; }

    [ForeignKey("NMEDICALSTAT")]
    public Insudb.TABLE9216? TABLE9216 { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }

    [NotMapped]
    public Insudb.ROLES? ROLESDEFFECDATE
    {
        get => ROLESSCERTYPE;
        set => ROLESSCERTYPE = value;
    }
    public int? NMONTHS { get; set; }
}
