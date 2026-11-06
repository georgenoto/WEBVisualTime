#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DURPAY_PROD
{
    public int NID { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int? NIDURAFIX { get; set; }
    public int? NPDURAFIX { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NTYPDURINS { get; set; }

    [ForeignKey("NTYPDURINS")]
    public Insudb.TABLE5589? TABLE5589NTYPDURINS { get; set; }
    public int? NTYPDURPAY { get; set; }

    [ForeignKey("NTYPDURPAY")]
    public Insudb.TABLE5589? TABLE5589NTYPDURPAY { get; set; }
}
