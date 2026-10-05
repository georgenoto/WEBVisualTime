#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class LIFE_SPECI
{
    public int NAGEEND { get; set; }
    public int NAGESTART { get; set; }
    public decimal NCAPEND { get; set; }
    public long NCONSEC { get; set; }
    public decimal NCAPSTART { get; set; }
    public int NMODULEC { get; set; }
    public int NBRANCH { get; set; }
    public int NCOVER { get; set; }
    public int NCURRENCY { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCRTHECNI { get; set; }

    [ForeignKey("NCRTHECNI")]
    public Insudb.TABLE32? TABLE32 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SSEXCLIEN { get; set; }

    [ForeignKey("SSEXCLIEN")]
    public Insudb.TABLE18? TABLE18 { get; set; }
    public int? NUSERCODE { get; set; }
    public int NROLE { get; set; }
    public string? SRANDOM { get; set; }
}
