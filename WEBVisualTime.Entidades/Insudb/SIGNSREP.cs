#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SIGNSREP
{
    public int NUSERSIGN { get; set; }

    [ForeignKey("NUSERSIGN")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SPOSITION { get; set; }
    public string SPATHSING { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SSTATREG { get; set; }
}
