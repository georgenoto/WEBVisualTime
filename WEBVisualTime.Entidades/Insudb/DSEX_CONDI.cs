#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DSEX_CONDI
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NDISEXPRC { get; set; }
    public int NAPLICATION { get; set; }

    [ForeignKey("NAPLICATION")]
    public Insudb.TABLE298? TABLE298 { get; set; }
    public int NCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NMODULEC { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NROLE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NRATE { get; set; }
}
