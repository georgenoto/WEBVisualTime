#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TREINSURAN_CESSION
{
    public string? SCERTYPE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public int? NTYPE_REIN { get; set; }
    public string? SCLIENT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public int? NCOMPANY { get; set; }
    public int? NCOVAPPSCOPE { get; set; }
    public int? NBRANCH_REI { get; set; }
    public decimal? NSHARE { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NLIMITFROM { get; set; }
    public decimal? NLIMIT { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOMMISSI { get; set; }
    public decimal? NPREMIUM_AGREE { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NCOMMISSIONAMOUNT { get; set; }
    public decimal? NTAXPERCEN { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public string? SKEY { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NORDER { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NNUMBER { get; set; }
    public DateTime? DISSUEDATE { get; set; }
}
