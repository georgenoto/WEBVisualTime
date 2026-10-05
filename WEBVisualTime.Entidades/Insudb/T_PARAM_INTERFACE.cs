#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_PARAM_INTERFACE
{
    public string SKEY { get; set; }
    public int NFIELD { get; set; }
    public string? SVALUE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
