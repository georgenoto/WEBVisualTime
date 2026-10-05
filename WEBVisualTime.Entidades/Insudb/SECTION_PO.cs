#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SECTION_PO
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public string SPOLITYPE { get; set; }
    public string SCOMPON { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int NTRATYPEP { get; set; }

    [ForeignKey("NTRATYPEP")]
    public Insudb.TABLE5588? TABLE5588 { get; set; }
    public int? NSEQUENCE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int NID { get; set; }
    public int NORIGIN { get; set; }

    [ForeignKey("NORIGIN")]
    public Insudb.TABLE5580? TABLE5580 { get; set; }
    public int? NTYPE_AMEND { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SREPORT { get; set; }
    public int? NORDER { get; set; }
    public string? SROUTINE { get; set; }
    public string? SDESCRIPT { get; set; }
}
