#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_ACTIONS_STATE
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NSTATUS { get; set; }
    public string SIND_CHANGE { get; set; }
    public string SIND_QUERY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NCLAIM_ENTITY { get; set; }

    [ForeignKey("NCLAIM_ENTITY")]
    public Insudb.TABLE9262? TABLE9262 { get; set; }
    public int NACTIONCLAIM { get; set; }
}
