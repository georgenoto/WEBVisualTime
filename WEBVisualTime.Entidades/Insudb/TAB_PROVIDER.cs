#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROVIDER
{
    public int NPROVIDER { get; set; }
    public int NTYPEPROV { get; set; }

    [ForeignKey("NTYPEPROV")]
    public Insudb.TAB_PROV_SUBTYPES? TAB_PROV_SUBTYPESNTYPEPROV { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DINPDATE { get; set; }
    public DateTime? DOUTDATE { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int? NMAX_SERV_ORD { get; set; }
    public int NTYPESUPPORT { get; set; }

    [ForeignKey("NTYPESUPPORT")]
    public Insudb.TABLE5570? TABLE5570 { get; set; }
    public decimal? NPER_DISC { get; set; }
    public string SCONCESIONARY { get; set; }
    public string? SAGENCYDESC { get; set; }
    public int NCLASS_PROV { get; set; }

    [ForeignKey("NCLASS_PROV")]
    public Insudb.TABLE9253? TABLE9253 { get; set; }
    public int NCATEG_PROV { get; set; }

    [ForeignKey("NCATEG_PROV")]
    public Insudb.TABLE9259? TABLE9259 { get; set; }
    public int NTYPEDISC_PROV { get; set; }

    [ForeignKey("NTYPEDISC_PROV")]
    public Insudb.TABLE9254? TABLE9254 { get; set; }
    public int NSUBTYPEPROV { get; set; }

    [ForeignKey("NSUBTYPEPROV")]
    public Insudb.TAB_PROV_SUBTYPES? TAB_PROV_SUBTYPESNSUBTYPEPROV { get; set; }
    public DateTime? DREQDATE { get; set; }
    public DateTime? DREGDATE { get; set; }
    public decimal? NDISC_PROV { get; set; }
    public int? NCURRDISC_PROV { get; set; }
    public decimal? NAMODISC_PROV { get; set; }
    public int NPAYMENT_METHOD { get; set; }

    [ForeignKey("NPAYMENT_METHOD")]
    public Insudb.TABLE9252? TABLE9252 { get; set; }
    public int? NJOINED { get; set; }
    public int NCOD_INSTEDUC { get; set; }

    [ForeignKey("NCOD_INSTEDUC")]
    public Insudb.TABLE9255? TABLE9255 { get; set; }
    public int NCOD_MEDCOLLEGE { get; set; }

    [ForeignKey("NCOD_MEDCOLLEGE")]
    public Insudb.TABLE9256? TABLE9256 { get; set; }
    public string? SINTERNATIONALPROVIDER { get; set; }
}
