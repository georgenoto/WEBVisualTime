#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_MASIVECHARGE
{
    public string SKEY { get; set; }
    public long NROWS { get; set; }
    public long NCOLUMNS { get; set; }
    public string SFIELD { get; set; }
    public string? SVALUE { get; set; }
    public int NSEARCH { get; set; }

    [ForeignKey("NSEARCH")]
    public Insudb.TABLE5571? TABLE5571 { get; set; }
    public string STABLE { get; set; }
    public string? SVALUESLIST { get; set; }
}
