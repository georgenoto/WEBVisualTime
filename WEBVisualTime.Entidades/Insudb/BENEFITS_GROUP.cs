#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BENEFITS_GROUP
{
    public string SBENEFITGROUP { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public int NTYPE_GROUP { get; set; }

    [ForeignKey("NTYPE_GROUP")]
    public Insudb.TABLE8606? TABLE8606 { get; set; }
    public string? SCLARIFICACT { get; set; }
}
