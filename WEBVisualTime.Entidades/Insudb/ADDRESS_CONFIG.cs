#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ADDRESS_CONFIG
{
    public int COUNTRY { get; set; }
    public string? ADDRESS_SETTINGS { get; set; }
    public string? PHONE_SETTINGS { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? UPDATEDATE { get; set; }
}
