#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TOAD_PLAN_SQL
{
    public string? USERNAME { get; set; }
    public string? STATEMENT_ID { get; set; }
    public DateTime? TIMESTAMP { get; set; }
    public string? STATEMENT { get; set; }
}
