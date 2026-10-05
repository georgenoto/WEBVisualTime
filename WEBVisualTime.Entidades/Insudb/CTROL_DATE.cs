#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CTROL_DATE
{
    public int NTYPE_PROCE { get; set; }

    [ForeignKey("NTYPE_PROCE")]
    public Insudb.TABLE526? TABLE526 { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNEXTDATEPROC { get; set; }
}
