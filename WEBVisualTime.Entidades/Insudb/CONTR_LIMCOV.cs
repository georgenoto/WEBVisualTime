#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTR_LIMCOV
{
    public int NBRANCH_REI { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NNUMBER { get; set; }
    public int NTYPE { get; set; }
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public int NCOVERGEN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public decimal? NLINES { get; set; }
    public decimal? NQUOTA_SHA { get; set; }
    public string? SROUTINE { get; set; }
    public int? NCOVERAPP { get; set; }
    public decimal? NPERCENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NMAXAMOUNT { get; set; }
}
