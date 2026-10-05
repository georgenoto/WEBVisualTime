#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LIMITS
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public int NCURRENCY { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public decimal? NCLAIM_D { get; set; }
    public int NPRODUCT { get; set; }
    public decimal? NCLAIM_P { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NISSUELIM { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
