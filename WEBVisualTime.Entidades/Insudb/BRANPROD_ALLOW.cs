#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BRANPROD_ALLOW
{
    public long NINTERMED { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMODULEC { get; set; }
    public int NINSTALLMENTS { get; set; }
    public int NSTARTMONTH { get; set; }
    public int NENDMONTH { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NNOTE_INT { get; set; }
    public int? NCATEGORY { get; set; }

    [ForeignKey("NCATEGORY")]
    public Insudb.TABLE9202? TABLE9202 { get; set; }
}
