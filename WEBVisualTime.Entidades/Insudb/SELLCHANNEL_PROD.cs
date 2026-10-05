#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SELLCHANNEL_PROD
{
    public DateTime DEFFECDATE { get; set; }
    public int NCLASSIFICATION { get; set; }

    [ForeignKey("NCLASSIFICATION")]
    public Insudb.TABLE9223? TABLE9223 { get; set; }
    public int NINTERTYP { get; set; }

    [ForeignKey("NINTERTYP")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
    public int NSELLCHANNEL { get; set; }

    [ForeignKey("NSELLCHANNEL")]
    public Insudb.TABLE5532? TABLE5532 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
}
