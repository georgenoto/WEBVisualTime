#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_COMPRO
{
    public int NTYPE_TRAN { get; set; }

    [ForeignKey("NTYPE_TRAN")]
    public Insudb.TABLE6? TABLE6 { get; set; }
    public int NLINE { get; set; }
    public int? NTYP_ACCO { get; set; }
    public string? SDEBITSIDE { get; set; }
    public int? NTYP_AMOUNT { get; set; }

    [ForeignKey("NTYP_AMOUNT")]
    public Insudb.TABLE532? TABLE532 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
