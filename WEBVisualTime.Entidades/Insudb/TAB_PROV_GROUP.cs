#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_GROUP
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public int NPROV_GROUP { get; set; }

    [ForeignKey("NPROV_GROUP")]
    public Insudb.TABLE642? TABLE642 { get; set; }
    public DateTime? DINPDATE { get; set; }
    public DateTime? DOUTDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
