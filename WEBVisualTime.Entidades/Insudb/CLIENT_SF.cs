#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_SF
{
    public string SCLIENT { get; set; }
    public string SDIGIT { get; set; }
    public int? NPOSITION { get; set; }

    [ForeignKey("NPOSITION")]
    public Insudb.TABLE8004? TABLE8004 { get; set; }
    public DateTime? DSTARTCONDITION { get; set; }
    public DateTime? DENDCONDITION { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NPLACEBIRTH { get; set; }
    public int? NSECOND_NATIONALITY { get; set; }
    public int? NRESIDENT_FORMER { get; set; }
    public string? SUSADDRES { get; set; }
    public string? SUSLEGAL_PERSON { get; set; }
    public string? SUSPHONE { get; set; }
    public string? SUSACCOUNT { get; set; }
    public string? SSSN { get; set; }
    public string? SUS_ITINNUM { get; set; }
    public string? SUS_IRSIND { get; set; }
    public string? SPLACEBIRTH { get; set; }
    public int NTYPELIST { get; set; }
}
