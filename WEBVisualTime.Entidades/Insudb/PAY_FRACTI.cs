#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PAY_FRACTI
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NPAYFREQ { get; set; }

    [ForeignKey("NPAYFREQ")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public int NQUOTA { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NRATEPAYF { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
}
