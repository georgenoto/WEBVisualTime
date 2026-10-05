#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RELATIONSHIP
{
    public int NIDRELATIONSHIP { get; set; }
    public string SNAME { get; set; }
    public string? SENABLE { get; set; }
}
