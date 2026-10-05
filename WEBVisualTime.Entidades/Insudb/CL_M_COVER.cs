#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CL_M_COVER
{
    public long NCLAIM { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public int NTRANSAC { get; set; }
    public int NCOVER { get; set; }
    public int NMODULEC { get; set; }
    public int NCURRENCY { get; set; }
    public decimal? NAMOUNT { get; set; }
    public string SCLIENT { get; set; }
    public string? SAUT_ADJUST { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NDED_AMOUNT { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public decimal? NEXP_AMOUNT { get; set; }
    public int? NGROUP { get; set; }
    public decimal? NLOC_AMOUNT { get; set; }
    public int? NQUANTITY { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NVA_TAX { get; set; }
    public decimal? NVAT_AMOUNT { get; set; }
    public decimal? NLOC_COS_RE { get; set; }
    public string? SCESCATAS { get; set; }
    public int? NSETTLECODE { get; set; }
    public string? SPOSTEDSEQUENCE { get; set; }
}
