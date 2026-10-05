#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ACTIONS
{
    public int NACTION { get; set; }
    public string? SCONTROLKEY { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SHEL_ACTIO { get; set; }
    public string? SSHORT_ACTI { get; set; }
    public string SSTATREGT { get; set; }
    public string? STYPE_ACTIO { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SPATHIMAGE { get; set; }
}
