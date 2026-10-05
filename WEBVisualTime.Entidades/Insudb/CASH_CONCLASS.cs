#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CASH_CONCLASS
{
    public int NCLASS_CONCEPT { get; set; }

    [ForeignKey("NCLASS_CONCEPT")]
    public Insudb.TABLE5650? TABLE5650 { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE22? TABLE22 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
}
