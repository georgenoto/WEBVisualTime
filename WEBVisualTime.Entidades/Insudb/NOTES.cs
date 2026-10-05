#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class NOTES
{
    public long NNOTENUM { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCONSEC { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? TDS_TEXT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NRECTYPE { get; set; }

    [ForeignKey("NRECTYPE")]
    public Insudb.TABLE62? TABLE62 { get; set; }
    public int? NUSERCODE { get; set; }
}
