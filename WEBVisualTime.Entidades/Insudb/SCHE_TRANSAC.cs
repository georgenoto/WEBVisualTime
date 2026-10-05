#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SCHE_TRANSAC
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NTRANSAC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public string? SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE182? TABLE182 { get; set; }
    public int NTYPE_AMEND { get; set; }

    [ForeignKey("NTYPE_AMEND")]
    public Insudb.TABLE6059? TABLE6059 { get; set; }
    public long NID { get; set; }
}
