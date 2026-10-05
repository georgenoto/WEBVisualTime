#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_PRESCRIPTION
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMONTHS { get; set; }
    public int NDAYS { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCLA_LI_TYP { get; set; }
}
