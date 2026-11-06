#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_CONTACT
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public int NSEQ { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NPOSITION { get; set; }

    [ForeignKey("NPOSITION")]
    public Insudb.TABLE283? TABLE283 { get; set; }
    public string? SNAME_CONTACT { get; set; }
    public string? SE_MAIL { get; set; }
    public string? SPHONE_CONTACT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
