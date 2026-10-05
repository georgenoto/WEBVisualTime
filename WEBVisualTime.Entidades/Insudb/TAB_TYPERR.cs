#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_TYPERR
{
    public int NTYPE_ERR { get; set; }
    public int NTYPEERR_PA { get; set; }

    [ForeignKey("NTYPEERR_PA")]
    public Insudb.TAB_TYPERR? TAB_TYPERRParent { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public string? STRANSITI { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
