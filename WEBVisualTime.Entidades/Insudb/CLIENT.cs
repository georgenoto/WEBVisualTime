#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT
{
    public string SCLIENT { get; set; }
    public string? SACCOUNT_IN { get; set; }
    public int NINVOICING { get; set; }

    [ForeignKey("NINVOICING")]
    public Insudb.TABLE5522? TABLE5522 { get; set; }
    public int NCIVILSTA { get; set; }

    [ForeignKey("NCIVILSTA")]
    public Insudb.TABLE14? TABLE14 { get; set; }
    public DateTime? DAPROBDATE { get; set; }
    public DateTime? DBIRTHDAT { get; set; }
    public string? SBLOCKADE { get; set; }
    public int NCLASS { get; set; }

    [ForeignKey("NCLASS")]
    public Insudb.TABLE146? TABLE146 { get; set; }
    public string? SFIRSTNAME { get; set; }
    public string? SLASTNAME { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DDEATHDAT { get; set; }
    public DateTime? DDRIVERDAT { get; set; }
    public decimal? NHEIGHT { get; set; }
    public DateTime? DINPDATE { get; set; }
    public int NHOUSE_TYPE { get; set; }

    [ForeignKey("NHOUSE_TYPE")]
    public Insudb.TABLE149? TABLE149 { get; set; }
    public string? SLICENSE { get; set; }
    public long? NNOTENUM { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int? NQ_CARS { get; set; }
    public int? NQ_CHILD { get; set; }
    public decimal? NRATE { get; set; }
    public string? STAX_CODE { get; set; }
    public string? SSEXCLIEN { get; set; }

    [ForeignKey("SSEXCLIEN")]
    public Insudb.TABLE18? TABLE18 { get; set; }
    public string? SSMOKING { get; set; }
    public string? SCUIT { get; set; }
    public int NTITLE { get; set; }

    [ForeignKey("NTITLE")]
    public Insudb.TABLE222? TABLE222 { get; set; }
    public int NUSERCODE { get; set; }
    public decimal? NWEIGHT { get; set; }
    public string? SAUTO_CHAR { get; set; }
    public string? SCREDIT_CARD { get; set; }
    public int NECONOMIC_L { get; set; }

    [ForeignKey("NECONOMIC_L")]
    public Insudb.TABLE147? TABLE147 { get; set; }
    public long? NEMPL_QUA { get; set; }
    public long? NIMAGENUM { get; set; }
    public int NPERSON_TYP { get; set; }

    [ForeignKey("NPERSON_TYP")]
    public Insudb.TABLE5006? TABLE5006 { get; set; }
    public long NAREA { get; set; }

    [ForeignKey("NAREA")]
    public Insudb.TABLE5503? TABLE5503 { get; set; }
    public DateTime? DDRIVEXPDAT { get; set; }
    public int NTYPDRIVER { get; set; }

    [ForeignKey("NTYPDRIVER")]
    public Insudb.TABLE5504? TABLE5504 { get; set; }
    public int NDISABILITY { get; set; }

    [ForeignKey("NDISABILITY")]
    public Insudb.TABLE5505? TABLE5505 { get; set; }
    public int NLIMITDRIV { get; set; }

    [ForeignKey("NLIMITDRIV")]
    public Insudb.TABLE5521? TABLE5521 { get; set; }
    public string? SLEGALNAME { get; set; }
    public string? SLASTNAME2 { get; set; }
    public int NHEALTH_ORG { get; set; }

    [ForeignKey("NHEALTH_ORG")]
    public Insudb.TABLE5523? TABLE5523 { get; set; }
    public int NAFP { get; set; }

    [ForeignKey("NAFP")]
    public Insudb.TABLE5524? TABLE5524 { get; set; }
    public DateTime? DWEDD { get; set; }
    public string? SBILL_IND { get; set; }
    public int NINCAPACITY { get; set; }

    [ForeignKey("NINCAPACITY")]
    public Insudb.TABLE5549? TABLE5549 { get; set; }
    public DateTime? DINCAPACITY { get; set; }
    public int NINCAP_COD { get; set; }

    [ForeignKey("NINCAP_COD")]
    public Insudb.TABLE5550? TABLE5550 { get; set; }
    public int NNATIONALITY { get; set; }

    [ForeignKey("NNATIONALITY")]
    public Insudb.TABLE5518? TABLE5518 { get; set; }
    public string SDIGIT { get; set; }
    public DateTime? DRETIREMENT { get; set; }
    public DateTime? DINDEPENDANT { get; set; }
    public DateTime? DDEPENDANT { get; set; }
    public int NMAILINGPREF { get; set; }
    public int NLANGUAGE { get; set; }

    [ForeignKey("NLANGUAGE")]
    public Insudb.TABLE85? TABLE85 { get; set; }
    public long? NSPECIALITY { get; set; }
    public int? NCOMP_TYPE { get; set; }
    public string? SCLIENAME { get; set; }
    public string? SLEDGERPROCESS { get; set; }
    public string? SCOMPLCOD { get; set; }
    public int NTYPECOMPANY { get; set; }
    public string? SFATCA { get; set; }
    public string? SCLIENTPEP { get; set; }
    public string? SUSPERSON { get; set; }
    public long? NADDRESSID { get; set; }
    public long? NPHONEID { get; set; }
    public string? SCRS { get; set; }
    public string? SMARRIEDSURNAME { get; set; }
    public string? SSPOUSENAME { get; set; }
    public string? SOTHERTITLE { get; set; }
    public string? SOTHERSPECIALITY { get; set; }
    public int NRESIDENCECOUNTRY { get; set; }

    [ForeignKey("NRESIDENCECOUNTRY")]
    public Insudb.TABLE66? TABLE66NRESIDENCECOUNTRY { get; set; }
    public int NBIRTHCOUNTRY { get; set; }

    [ForeignKey("NBIRTHCOUNTRY")]
    public Insudb.TABLE66? TABLE66NBIRTHCOUNTRY { get; set; }
    public int NPOSITION_CLI { get; set; }

    [ForeignKey("NPOSITION_CLI")]
    public Insudb.TABLE9213? TABLE9213 { get; set; }
    public string? NCLASEMPRESALEGAL { get; set; }
}
