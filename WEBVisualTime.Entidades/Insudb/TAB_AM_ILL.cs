#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_AM_ILL
{
    public string SILLNESS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SDESCRIPT { get; set; }
    public string? SILL_OMS { get; set; }

    [ForeignKey("SILL_OMS")]
    public Insudb.TABLE8602? TABLE8602 { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public string? SIND_SEVERITY { get; set; }
    public string? SIND_FRECUENCY { get; set; }
}
