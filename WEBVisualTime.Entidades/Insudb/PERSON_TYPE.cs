#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PERSON_TYPE
{
    public long NIDPERSONTYPE { get; set; }
    public string? SNAME { get; set; }
    public string? SENABLE { get; set; }
}
