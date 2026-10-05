#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_FN_INSTITUTION
{
    public int NINSTITUTION { get; set; }
    public int NTYPEINSTITU { get; set; }

    [ForeignKey("NTYPEINSTITU")]
    public Insudb.TABLE5634? TABLE5634 { get; set; }
    public string SNAME { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string SSTATREGT { get; set; }
    public string? SINSTITUTION { get; set; }
    public string? SCLIENT { get; set; }
    public string? SDIGIT { get; set; }
}
