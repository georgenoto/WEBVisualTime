#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SEQUEN_POL
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public string SBUSSITYP { get; set; }
    public int NTRATYPEP { get; set; }

    [ForeignKey("NTRATYPEP")]
    public Insudb.TABLE5588? TABLE5588 { get; set; }
    public string SPOLITYPE { get; set; }
    public string SCOMPON { get; set; }
    public int NSEQUENCE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SREQUIRE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SAUTOMATIC { get; set; }
    public int NTYPE_AMEND { get; set; }
}
