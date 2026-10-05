#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTRMASTER
{
    public int NTYPE_REL { get; set; }
    public int NNUMBER { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.TABLE173? TABLE173 { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int NCURRENCY { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public int? NCURR_PAY { get; set; }
    public string? SFORMPAY { get; set; }
}
