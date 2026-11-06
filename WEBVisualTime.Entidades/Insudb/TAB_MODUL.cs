#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_MODUL
{
    public int NBRANCH { get; set; }
    public int NMODULEC { get; set; }
    public int NPRODUCT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SCHANALLO { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SREQUIRE { get; set; }
    public string? SSHORT_DES { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCONDSVS { get; set; }
    public string? SROUTINE { get; set; }
    public decimal? NPREMIRAT { get; set; }
    public int? NCHPRELEV { get; set; }
    public decimal? NRATEPREADD { get; set; }
    public decimal? NRATEPRESUB { get; set; }
    public string? SCHANGETYP { get; set; }
    public string? STYP_RAT { get; set; }
    public string? SVIGEN { get; set; }
    public string? SDEPEND { get; set; }
    public string? SCLAIMMANDATORYFIELDS { get; set; }
    public int? NGEOGRAPHAREA { get; set; }

    [ForeignKey("NGEOGRAPHAREA")]
    public Insudb.TABLE9214? TABLE9214 { get; set; }
    public int? NATTENSYSTEM { get; set; }

    [ForeignKey("NATTENSYSTEM")]
    public Insudb.TABLE9215? TABLE9215 { get; set; }
}
