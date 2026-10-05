#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAX_FIXVAL
{
    public int NCODE { get; set; }
    public string STYPETAX { get; set; }

    [ForeignKey("STYPETAX")]
    public Insudb.TABLE5602? TABLE5602 { get; set; }
    public int NTYPESUPPORT { get; set; }

    [ForeignKey("NTYPESUPPORT")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
}
