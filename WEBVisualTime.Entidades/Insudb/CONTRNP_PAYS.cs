#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTRNP_PAYS
{
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NNUMBER, NBRANCH_REI, DEFFECDATE, NTYPE")]
    public Insudb.CONTRNPRO? CONTRNPRONBRANCH_REI { get; set; }
    public DateTime DEFFECDATE { get; set; }

    [NotMapped]
    public Insudb.CONTRNPRO? CONTRNPRODEFFECDATE
    {
        get => CONTRNPRONBRANCH_REI;
        set => CONTRNPRONBRANCH_REI = value;
    }
    public int NNUMBER { get; set; }

    [NotMapped]
    public Insudb.CONTRNPRO? CONTRNPRONNUMBER
    {
        get => CONTRNPRONBRANCH_REI;
        set => CONTRNPRONBRANCH_REI = value;
    }
    public int NTYPE { get; set; }

    [NotMapped]
    public Insudb.CONTRNPRO? CONTRNPRONTYPE
    {
        get => CONTRNPRONBRANCH_REI;
        set => CONTRNPRONBRANCH_REI = value;
    }
    public int NMONTH { get; set; }
    public int NYEAR { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SCUENTECN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
