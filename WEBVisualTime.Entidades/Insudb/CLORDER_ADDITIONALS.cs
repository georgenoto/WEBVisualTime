#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLORDER_ADDITIONALS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNDEMAN_TYPE { get; set; }
    public long NORDER_NUM { get; set; }

    [ForeignKey("NORDER_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNORDER_NUM { get; set; }
    public int NADDITIONAL_ORDER { get; set; }
    public string? SMEDICATION { get; set; }
    public int? NQUANTITYOFMEDICATION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
