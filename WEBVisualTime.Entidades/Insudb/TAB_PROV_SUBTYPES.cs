#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_SUBTYPES
{
    public int NTYPEPROV { get; set; }

    [ForeignKey("NTYPEPROV")]
    public Insudb.TABLE7027? TABLE7027 { get; set; }
    public int NSUBTYPEPROV { get; set; }
    public string SDESCRIPT { get; set; }
    public string SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
