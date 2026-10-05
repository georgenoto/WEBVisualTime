#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PROV_TABLIFCOV
{
    public int NCOVERGEN { get; set; }

    [ForeignKey("NCOVERGEN")]
    public Insudb.TAB_LIFCOV? TAB_LIFCOV { get; set; }
    public int NCOD_AGREE { get; set; }

    [ForeignKey("NCOD_AGREE")]
    public Insudb.AGREEMENT? AGREEMENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
