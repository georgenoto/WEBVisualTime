#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LEVELS
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public string SIND_TYPE { get; set; }

    [ForeignKey("SIND_TYPE")]
    public Insudb.TABLE511? TABLE511 { get; set; }
    public string SCODE_MT { get; set; }
    public int? NAMELEVEL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NINQLEVEL { get; set; }
    public string? SSUPERVIS { get; set; }
    public int NUSERCODE { get; set; }
    public string? SPERMITTED { get; set; }
    public string? SENCRYPTED { get; set; }
}
