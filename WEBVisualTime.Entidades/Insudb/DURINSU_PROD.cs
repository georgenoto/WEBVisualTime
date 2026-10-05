#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DURINSU_PROD
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NIDURAFIX { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NTYPDURINS { get; set; }

    [ForeignKey("NTYPDURINS")]
    public Insudb.TABLE5589? TABLE5589 { get; set; }
    public int? NMINDURINS { get; set; }
}
