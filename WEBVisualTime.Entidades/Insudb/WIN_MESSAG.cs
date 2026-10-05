#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class WIN_MESSAG
{
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public long NERRORNUM { get; set; }

    [ForeignKey("NERRORNUM")]
    public Insudb.MESSAGE? MESSAGE { get; set; }
    public string? SACTION_ERR { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SERRORTYP { get; set; }

    [ForeignKey("SERRORTYP")]
    public Insudb.TABLE153? TABLE153 { get; set; }
    public int? NLEVEL { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
}
