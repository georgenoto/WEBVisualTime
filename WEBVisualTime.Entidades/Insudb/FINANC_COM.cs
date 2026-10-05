#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FINANC_COM
{
    public decimal? NAMOUNT { get; set; }
    public long NRECEIPT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
