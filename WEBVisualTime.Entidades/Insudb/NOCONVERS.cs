#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class NOCONVERS
{
    public int NNO_CONVERS { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NAREAWAIT { get; set; }

    [ForeignKey("NAREAWAIT")]
    public Insudb.TABLE5603? TABLE5603 { get; set; }
    public string? SDEVO { get; set; }
    public string? SDISC { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NEXPENSES { get; set; }
    public string? SROUTINE { get; set; }
    public decimal? NHEALTHEXP { get; set; }
}
