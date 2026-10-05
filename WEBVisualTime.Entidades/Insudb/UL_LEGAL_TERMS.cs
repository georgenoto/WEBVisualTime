#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class UL_LEGAL_TERMS
{
    public int NTYPE_SAAPV { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NVALUESTY { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NVALUESMO { get; set; }
    public int? NDAYADD { get; set; }
}
