#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class NULL_CONDI
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE13? TABLE13 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NAMELEVEL { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SREGTYPEN { get; set; }
    public string? SRETURN_IND { get; set; }
    public decimal? NRETURN_RAT { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string SNOTREHAB { get; set; }
    public string SREHAB_AUTO { get; set; }
    public string? SROUTINE_PAY { get; set; }
    public int? NRETRACTION { get; set; }
}
