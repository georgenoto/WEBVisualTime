#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class OFF_ACC
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SIND_INQU { get; set; }
    public string? SIND_UPDA { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
