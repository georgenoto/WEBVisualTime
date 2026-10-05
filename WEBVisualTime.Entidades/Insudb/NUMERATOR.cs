#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class NUMERATOR
{
    public int NTYPENUM { get; set; }
    public int NORD_NUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long? NEND_NUM { get; set; }
    public long? NINITIAL { get; set; }
    public long? NLASTNUMB { get; set; }
    public int NUSERCODE { get; set; }
}
