#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DIR_DEBIT_CLI
{
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SACCOUNT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public string? SBANKAUTH { get; set; }
    public int NBILL_DAY { get; set; }
    public int? NSTATUS_BANKAUTH { get; set; }
}
