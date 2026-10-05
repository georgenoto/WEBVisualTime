#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RNULLCONDI
{
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE95? TABLE95 { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }
    public string SPOLITYPE { get; set; }
    public int NTRATYPEI { get; set; }
    public string? SPOLICY { get; set; }

    [ForeignKey("SPOLICY")]
    public Insudb.TABLE7505? TABLE7505SPOLICY { get; set; }
    public string? SCERTIF { get; set; }

    [ForeignKey("SCERTIF")]
    public Insudb.TABLE7505? TABLE7505SCERTIF { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
}
