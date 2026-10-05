#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MARGENREP
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NREPTYPE { get; set; }
    public string? SLOGO { get; set; }
    public string? SLOG { get; set; }
    public decimal? X1 { get; set; }
    public decimal? Y1 { get; set; }
    public decimal? NIMAGENX { get; set; }
    public decimal? NIMAGENY { get; set; }
    public decimal? NPOSIMGX { get; set; }
    public decimal? NPOSIMGY { get; set; }
    public decimal? NRADIOCURVA { get; set; }
    public decimal? NSPACE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
