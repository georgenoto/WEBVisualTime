#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTRNP_PAYS
{
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.CONTRNPRO? CONTRNPRONBRANCH_REI { get; set; }
    public DateTime DEFFECDATE { get; set; }

    [ForeignKey("DEFFECDATE")]
    public Insudb.CONTRNPRO? CONTRNPRODEFFECDATE { get; set; }
    public int NNUMBER { get; set; }

    [ForeignKey("NNUMBER")]
    public Insudb.CONTRNPRO? CONTRNPRONNUMBER { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.CONTRNPRO? CONTRNPRONTYPE { get; set; }
    public int NMONTH { get; set; }
    public int NYEAR { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SCUENTECN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
