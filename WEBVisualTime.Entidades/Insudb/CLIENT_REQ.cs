#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_REQ
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NROLE { get; set; }
    public int NTRATYPEP { get; set; }
    public int NFIELD { get; set; }

    [ForeignKey("NFIELD")]
    public Insudb.TABLE8017? TABLE8017 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SBIRTHDAI { get; set; }
    public string? SCIVISTAI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SREQUIRED { get; set; }
    public string? SOCCUPATI { get; set; }
    public string? SSEXINSUI { get; set; }
    public int? NUSERCODE { get; set; }
    public string? STAX_SITUA { get; set; }
    public string? SADDRESS { get; set; }
    public string? SCREDITLINE { get; set; }
}
