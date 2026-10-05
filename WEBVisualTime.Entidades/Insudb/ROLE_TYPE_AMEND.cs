#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ROLE_TYPE_AMEND
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TYPE_AMEND? TYPE_AMENDNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.TYPE_AMEND? TYPE_AMENDNPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }

    [ForeignKey("DEFFECDATE")]
    public Insudb.TYPE_AMEND? TYPE_AMENDDEFFECDATE { get; set; }
    public int NTYPE_AMEND { get; set; }

    [ForeignKey("NTYPE_AMEND")]
    public Insudb.TYPE_AMEND? TYPE_AMENDNTYPE_AMEND { get; set; }
    public int NROLEID { get; set; }
}
