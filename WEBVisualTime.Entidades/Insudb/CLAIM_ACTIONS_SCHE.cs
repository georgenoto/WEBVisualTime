#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_ACTIONS_SCHE
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NACTIONCLAIM { get; set; }

    [ForeignKey("NACTIONCLAIM")]
    public Insudb.TABLE9244? TABLE9244 { get; set; }
    public int NACTIONTYPE { get; set; }

    [ForeignKey("NACTIONTYPE")]
    public Insudb.TABLE9245? TABLE9245 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
