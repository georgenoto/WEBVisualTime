#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PRODMASTER
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SBRANCHT { get; set; }

    [ForeignKey("SBRANCHT")]
    public Insudb.TABLE37? TABLE37 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SREALIND { get; set; }
    public int? NCOMPANY { get; set; }
    public string? SPREFFIX { get; set; }
}
