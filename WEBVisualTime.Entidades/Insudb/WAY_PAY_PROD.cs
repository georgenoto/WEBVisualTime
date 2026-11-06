#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class WAY_PAY_PROD
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NWAY_PAY { get; set; }

    [ForeignKey("NWAY_PAY")]
    public Insudb.TABLE5002? TABLE5002 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal? NRATE_EX { get; set; }
    public decimal? NRATE_DISC { get; set; }
    public string SPREM_FIRST { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NNULL_DAY { get; set; }
    public string? SIND_PREISSU { get; set; }
    public string? SIND_PREREF { get; set; }
    public string? SONERECEIPT { get; set; }
    public string? SLASTRECEIPT { get; set; }
    public string? SCOLLECTION { get; set; }
    public string? SIND_PREREFMAX { get; set; }
    public string? SPRFIRST_EXPR { get; set; }
    public int? NTYPE_VALUECOLLECT { get; set; }

    [ForeignKey("NTYPE_VALUECOLLECT")]
    public Insudb.TABLE8215? TABLE8215 { get; set; }
}
