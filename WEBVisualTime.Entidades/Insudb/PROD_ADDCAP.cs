#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PROD_ADDCAP
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NCOVERGEN { get; set; }

    [ForeignKey("NCOVERGEN")]
    public Insudb.TAB_LIFCOV? TAB_LIFCOV { get; set; }
    public int NUSERCODE { get; set; }
    public int NBRANCHADD { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NPRODUCTADD { get; set; }
    public int NID { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NROLE { get; set; }
    public decimal? NCAPITAL { get; set; }
    public int? NCOVERADD { get; set; }
    public int? NROLEADD { get; set; }
    public int NTYP_CUMUL { get; set; }
}
