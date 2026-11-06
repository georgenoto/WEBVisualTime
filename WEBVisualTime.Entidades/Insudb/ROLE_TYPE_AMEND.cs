#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ROLE_TYPE_AMEND
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH, NPRODUCT, NTYPE_AMEND, DEFFECDATE")]
    public Insudb.TYPE_AMEND? TYPE_AMENDNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.TYPE_AMEND? TYPE_AMENDNPRODUCT
    {
        get => TYPE_AMENDNBRANCH;
        set => TYPE_AMENDNBRANCH = value;
    }
    public DateTime DEFFECDATE { get; set; }

    [NotMapped]
    public Insudb.TYPE_AMEND? TYPE_AMENDDEFFECDATE
    {
        get => TYPE_AMENDNBRANCH;
        set => TYPE_AMENDNBRANCH = value;
    }
    public int NTYPE_AMEND { get; set; }

    [NotMapped]
    public Insudb.TYPE_AMEND? TYPE_AMENDNTYPE_AMEND
    {
        get => TYPE_AMENDNBRANCH;
        set => TYPE_AMENDNBRANCH = value;
    }
    public int NROLEID { get; set; }
}
