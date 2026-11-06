#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_CLAUSE
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public int NCLAUSE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SSHORT_DES { get; set; }
    public int NUSERCODE { get; set; }
    public string? SMODIFIED { get; set; }
    public int? NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.TABLE7509? TABLE7509 { get; set; }
    public string? STYPE_CLAUSE { get; set; }
    public string? SDOC_ATTACH { get; set; }
    public int? NORDEN { get; set; }
    public string? STITCLAUSE { get; set; }
}
