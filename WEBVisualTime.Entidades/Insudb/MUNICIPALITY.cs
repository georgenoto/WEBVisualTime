#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MUNICIPALITY
{
    public int NMUNICIPALITY { get; set; }
    public int NLOCAL { get; set; }

    [ForeignKey("NLOCAL")]
    public Insudb.TAB_LOCAT? TAB_LOCAT { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
