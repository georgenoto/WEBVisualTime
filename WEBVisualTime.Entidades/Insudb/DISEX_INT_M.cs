#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DISEX_INT_M
{
    public int NECO_SCHE { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
}
