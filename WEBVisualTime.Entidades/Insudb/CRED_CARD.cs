#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CRED_CARD
{
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public string SCREDI_CARD { get; set; }
    public int NCARD_TYPE { get; set; }

    [ForeignKey("NCARD_TYPE")]
    public Insudb.TABLE183? TABLE183 { get; set; }
    public string? SSTATREGT { get; set; }
    public DateTime DCARDEXPIR { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public int? NCURRENCY { get; set; }
}
