#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLE140
{
    public int NOPER_TYPE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
