#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TIMEGLOBALS
{
    public string SCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NTYPEDATA { get; set; }
    public string SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
}
