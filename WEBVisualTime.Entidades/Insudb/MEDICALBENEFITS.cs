#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MEDICALBENEFITS
{
    public string SBENEFIT { get; set; }
    public string STYPEBENEFIT { get; set; }

    [ForeignKey("STYPEBENEFIT")]
    public Insudb.TABLE8600? TABLE8600 { get; set; }
    public string SBENEFITCLAS { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NIND_PACKAGE { get; set; }

    [ForeignKey("NIND_PACKAGE")]
    public Insudb.TABLE23? TABLE23 { get; set; }
}
