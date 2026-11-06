#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SIGNSCAPOFF
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public long NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11 { get; set; }
    public int NUSERSIGN { get; set; }

    [ForeignKey("NUSERSIGN")]
    public Insudb.USERS? USERS { get; set; }
    public int NORDSIGN { get; set; }
    public decimal NCAPMINSING { get; set; }
    public decimal NCAPMAXSING { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SSTATREG { get; set; }
}
