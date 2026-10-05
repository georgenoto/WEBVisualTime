#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LOGBILLS
{
    public int NINSUR_AREA { get; set; }
    public int NOPERTYPE { get; set; }
    public string SCLIENT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public long NBORDEREAUX { get; set; }
    public int NCURRENCY { get; set; }
    public decimal NAMOUNT { get; set; }
    public DateTime DSTATDATE { get; set; }
    public int NSTATUSCODE { get; set; }
    public string? SSTATUSDESC { get; set; }
    public string SBILLNUMSFE { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SPROCESSED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NRECEIPTCORP { get; set; }
}
