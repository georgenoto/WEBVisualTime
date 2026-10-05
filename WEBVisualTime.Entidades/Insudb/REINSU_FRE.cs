#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REINSU_FRE
{
    public string? SBUSSITYPE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NCOMPANY { get; set; }
    public string? SFREE { get; set; }
    public int NTYPE_REL { get; set; }
    public int NNUMBER { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NTYPE { get; set; }
    public long? NCLAIM_AM { get; set; }
    public int NYEAR_CONTR { get; set; }
    public decimal? NPREMIUM_AM { get; set; }
    public int NBRANCH { get; set; }
    public int NCURRENCY { get; set; }
    public int NTYPE_PER { get; set; }

    [ForeignKey("NTYPE_PER")]
    public Insudb.TABLE97? TABLE97 { get; set; }
    public int NPERIODY { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NYEAR { get; set; }
    public int? NYEAR_SER { get; set; }
}
