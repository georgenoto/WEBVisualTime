#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FORMATVALUES
{
    public int NTYPCLIENTDOC { get; set; }
    public string SDESCRIPT { get; set; }
    public string SSHORT_DES { get; set; }
    public int NCLASSTYPDOC { get; set; }

    [ForeignKey("NCLASSTYPDOC")]
    public Insudb.TABLE6023? TABLE6023 { get; set; }
    public string? SFORMAT { get; set; }
    public string STYPPERSON { get; set; }
    public string? SROUTINE { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
