#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class INTERM_TYP
{
    public int NINTERTYP { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SPARTICIN { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NTYP_ACCO { get; set; }

    [ForeignKey("NTYP_ACCO")]
    public Insudb.TABLE400? TABLE400 { get; set; }
    public string? SIND_FECU { get; set; }
    public string? SGEN_CERTIF { get; set; }
    public int NRECEPTYP { get; set; }
}
