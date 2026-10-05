#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BILLS_NUM
{
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public string SBILLTYPE { get; set; }
    public long NINITNUMB { get; set; }
    public long NENDNUMB { get; set; }
    public long NLASTBILL { get; set; }
    public DateTime DLASTCLOSED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
