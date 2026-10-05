#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class NONWORKINGDAYFACTOR
{
    public long NIDFACTOR { get; set; }
    public long NIDUSER { get; set; }

    [ForeignKey("NIDUSER")]
    public Insudb.APPUSER? APPUSER { get; set; }
    public decimal NFACTOR { get; set; }
    public DateTime? DCREATIONDATE { get; set; }
}
