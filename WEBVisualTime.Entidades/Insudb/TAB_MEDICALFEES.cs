#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_MEDICALFEES
{
    public int NIDMEDICALFEE { get; set; }
    public int NOFFICE { get; set; }
    public int NPROVIDER { get; set; }
    public int NCENTPROVIDER { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SSTATREGT { get; set; }
}
