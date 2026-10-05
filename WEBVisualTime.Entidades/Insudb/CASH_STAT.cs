#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CASH_STAT
{
    public int NCASHNUM { get; set; }
    public DateTime DSTATDATE { get; set; }
    public int NSTATUS { get; set; }

    [ForeignKey("NSTATUS")]
    public Insudb.TABLE5562? TABLE5562 { get; set; }
    public long NID { get; set; }
    public long NCASH_ID { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
