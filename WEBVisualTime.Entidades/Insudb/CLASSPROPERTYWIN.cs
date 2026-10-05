#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLASSPROPERTYWIN
{
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NIDCLASS { get; set; }
    public int NIDPROPERTY { get; set; }

    [ForeignKey("NIDPROPERTY")]
    public Insudb.PROPERTYLIBRARY? PROPERTYLIBRARY { get; set; }
    public string SVISIBLE { get; set; }
    public int NORDEN { get; set; }
    public string SCAPTION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NWIDTH { get; set; }
    public int NUSERCODE { get; set; }
    public string? SKEY { get; set; }
}
