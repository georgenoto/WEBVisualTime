#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class INTERMED_PARTIC
{
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public long? NSUPERIN_NUM { get; set; }
    public DateTime? DSUPERIN_NUM { get; set; }
    public long? NWARRAN_POL { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long? NCIRCULAR_DOC { get; set; }
    public DateTime? DEXPSUPERIN_NUM { get; set; }
}
