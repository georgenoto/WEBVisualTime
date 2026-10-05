#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASSIVE_RULES
{
    public long NIDRULE { get; set; }
    public long NERRORNUM { get; set; }
    public string SERRORTYP { get; set; }

    [ForeignKey("SERRORTYP")]
    public Insudb.TABLE153? TABLE153 { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SBREAK { get; set; }
    public string? SENABLED { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NACTIONPROC { get; set; }
    public string? SVIP { get; set; }
    public string? STYP_CONDI { get; set; }

    [ForeignKey("STYP_CONDI")]
    public Insudb.TABLE8204? TABLE8204 { get; set; }
    public int NSECTION { get; set; }

    [ForeignKey("NSECTION")]
    public Insudb.TABLE8205? TABLE8205 { get; set; }
}
