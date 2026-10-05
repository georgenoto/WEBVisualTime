#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PREMIUM_BKP_256518
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NRECEIPT { get; set; }
    public int NDIGIT { get; set; }
    public int NPAYNUMBE { get; set; }
    public long NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public int? NPERIOD_OLD { get; set; }
    public int? NPERIOD_NEW { get; set; }
    public DateTime? DFIX { get; set; }
}
