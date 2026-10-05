#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REINSU_PRIM_HEALTH
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.PRODMASTER? PRODMASTER { get; set; }
    public int NMODULEC { get; set; }
    public int NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11 { get; set; }
    public DateTime DEEFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NREINPRE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREG { get; set; }
    public int? NUSERCODE { get; set; }
}
