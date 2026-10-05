#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BENEFITS_CATEGORY
{
    public int NBENEFCATEG { get; set; }
    public string SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? STABLEASOC { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
