#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_HIS
{
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SCLIENAME { get; set; }
    public string? SFIRSTNAME { get; set; }
    public string? SLASTNAME { get; set; }
    public string? SLASTNAME2 { get; set; }
    public string? SSEXCLIEN { get; set; }

    [ForeignKey("SSEXCLIEN")]
    public Insudb.TABLE18? TABLE18 { get; set; }
    public int? NCIVILSTA { get; set; }

    [ForeignKey("NCIVILSTA")]
    public Insudb.TABLE14? TABLE14 { get; set; }
    public string? SBLOCKADE { get; set; }
    public int? NHEALTH_ORG { get; set; }

    [ForeignKey("NHEALTH_ORG")]
    public Insudb.TABLE5523? TABLE5523 { get; set; }
    public long? NAFP { get; set; }

    [ForeignKey("NAFP")]
    public Insudb.TABLE5524? TABLE5524 { get; set; }
    public DateTime? DWEDD { get; set; }
    public int? NINCAPACITY { get; set; }

    [ForeignKey("NINCAPACITY")]
    public Insudb.TABLE5549? TABLE5549 { get; set; }
    public int? NINCAP_COD { get; set; }

    [ForeignKey("NINCAP_COD")]
    public Insudb.TABLE5550? TABLE5550 { get; set; }
    public DateTime? DDRIVERDAT { get; set; }
    public DateTime? DDRIVEXPDAT { get; set; }
    public int? NTYPDRIVER { get; set; }

    [ForeignKey("NTYPDRIVER")]
    public Insudb.TABLE5504? TABLE5504 { get; set; }
    public int? NLIMITDRIV { get; set; }

    [ForeignKey("NLIMITDRIV")]
    public Insudb.TABLE5521? TABLE5521 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SLEGALNAME { get; set; }
    public DateTime? DINCAPACITY { get; set; }
    public int NID { get; set; }
    public DateTime? DDEPENDANT { get; set; }
    public DateTime? DINDEPENDANT { get; set; }
}
