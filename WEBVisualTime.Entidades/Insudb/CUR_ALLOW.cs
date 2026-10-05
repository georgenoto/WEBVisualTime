#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CUR_ALLOW
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDEFAULTI { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
}
