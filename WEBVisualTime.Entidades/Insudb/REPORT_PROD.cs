#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REPORT_PROD
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NREPTYPE { get; set; }
    public int NTRATYPEP { get; set; }
    public string? SREPORT { get; set; }
}
