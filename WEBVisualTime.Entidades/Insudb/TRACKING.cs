#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TRACKING
{
    public int ID { get; set; }
    public string? FACTTIME { get; set; }
    public string? HOSTSOURCE { get; set; }
    public string? FORMPATH { get; set; }
    public string? URLREFERRER { get; set; }
    public string? USERAGENT { get; set; }
    public string? FORMID { get; set; }
    public int? PURCHASEORDER { get; set; }
    public string? REMARK { get; set; }
    public string? CALLEDFROMID { get; set; }
}
