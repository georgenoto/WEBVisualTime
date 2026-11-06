#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMPANY
{
    public int NCOMPANY { get; set; }
    public string? SACCOUNT { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public string? SBANKNAME { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCOUNTRY { get; set; }

    [ForeignKey("NCOUNTRY")]
    public Insudb.TABLE66? TABLE66 { get; set; }
    public DateTime? DINPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public decimal? NTAXRATE { get; set; }
    public string? STYPE { get; set; }
    public string SREGSVS { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SNATIONAL { get; set; }
    public int? NCLASIFIC { get; set; }

    [ForeignKey("NCLASIFIC")]
    public Insudb.TABLE5563? TABLE5563 { get; set; }
    public string? SABA_ID { get; set; }
    public string? SWIFT_IT { get; set; }
    public int? NLOCAL { get; set; }

    [ForeignKey("NLOCAL")]
    public Insudb.TAB_LOCAT? TAB_LOCAT { get; set; }
    public string? SCITY { get; set; }
    public string? NBANKCOUNTRY { get; set; }
}
