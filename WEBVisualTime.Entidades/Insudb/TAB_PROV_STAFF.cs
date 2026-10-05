#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_STAFF
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDERNPROVIDER { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NSERV_ESTRUCT { get; set; }

    [ForeignKey("NSERV_ESTRUCT")]
    public Insudb.TABLE9258? TABLE9258 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NPROVIDER_REL { get; set; }

    [ForeignKey("NPROVIDER_REL")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDERNPROVIDER_REL { get; set; }
}
