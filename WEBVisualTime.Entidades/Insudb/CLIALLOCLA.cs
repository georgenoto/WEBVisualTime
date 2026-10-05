#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIALLOCLA
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SREQUIRE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NMAXNUM_ROL { get; set; }
    public string? SIND_CRECLI { get; set; }
    public string? SDEFAULT_CLA_IND { get; set; }
}
