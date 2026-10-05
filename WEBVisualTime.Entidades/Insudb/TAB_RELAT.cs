#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_RELAT
{
    public int NRELASHIP { get; set; }

    [ForeignKey("NRELASHIP")]
    public Insudb.TABLE15? TABLE15NRELASHIP { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NREL_TARGET { get; set; }

    [ForeignKey("NREL_TARGET")]
    public Insudb.TABLE15? TABLE15NREL_TARGET { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
}
