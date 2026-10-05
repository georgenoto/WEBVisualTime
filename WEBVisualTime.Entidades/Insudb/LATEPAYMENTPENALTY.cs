#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LATEPAYMENTPENALTY
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.PRODMASTER? PRODMASTER { get; set; }
    public int NDAY_INI { get; set; }
    public DateTime DEFFECTDATE { get; set; }
    public int? NDAY_END { get; set; }
    public int NDAYSPENALTY { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
