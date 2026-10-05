#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PROVISION_TYPE
{
    public int NIDPROVISIONTYPE { get; set; }
    public string? SNAME { get; set; }
    public string? SENABLE { get; set; }
    public string? SMANEJAUF { get; set; }
}
