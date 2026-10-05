#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FINANC_WIN
{
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public string? SV_CONCONTR { get; set; }
    public string? SV_WINCONTR { get; set; }
}
