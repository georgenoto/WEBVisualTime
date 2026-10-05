#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_MEDSPEC
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public string SMEDSPECIALIALTY { get; set; }

    [ForeignKey("SMEDSPECIALIALTY")]
    public Insudb.TABLE8603? TABLE8603 { get; set; }
    public int NMAIN_MEDSPECIALIALTY { get; set; }
    public string? SREG_MEDICALPROF { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
