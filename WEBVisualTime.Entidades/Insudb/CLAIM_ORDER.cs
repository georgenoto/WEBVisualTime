#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_ORDER
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE")]
    public Insudb.CLAIM_CASE? CLAIM_CASE { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public long NORDER_NUM { get; set; }
    public int? NCLAIMANTTYPE { get; set; }

    [ForeignKey("NCLAIMANTTYPE")]
    public Insudb.TABLE9212? TABLE9212 { get; set; }
    public int? NATTENTCHANNEL { get; set; }

    [ForeignKey("NATTENTCHANNEL")]
    public Insudb.TABLE9237? TABLE9237 { get; set; }
    public DateTime? DORDERDATE { get; set; }
    public int? NTYPEDOC_PAY { get; set; }

    [ForeignKey("NTYPEDOC_PAY")]
    public Insudb.TABLE9242? TABLE9242 { get; set; }
    public DateTime? DACCOUNTDOC { get; set; }
    public long? NCURREN_DOC { get; set; }

    [ForeignKey("NCURREN_DOC")]
    public Insudb.TABLE11? TABLE11NCURREN_DOC { get; set; }
    public int? NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public string? STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public long? NCURREN_ORDER { get; set; }

    [ForeignKey("NCURREN_ORDER")]
    public Insudb.TABLE11? TABLE11NCURREN_ORDER { get; set; }
    public int? NSTATUS_ORDER { get; set; }

    [ForeignKey("NSTATUS_ORDER")]
    public Insudb.TABLE9241? TABLE9241 { get; set; }
    public int? NORDERTYPE { get; set; }

    [ForeignKey("NORDERTYPE")]
    public Insudb.TABLE9238? TABLE9238 { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public long? NNOTENUM { get; set; }
    public string? NMOVEMENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCARECLASS { get; set; }
    public int? NUSER_AMEND { get; set; }
    public int? NUSER_AUDITDOC { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int? NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE9263? TABLE9263 { get; set; }
    public int? NUSER_DERIVEDBY { get; set; }
    public long? NMASTERORDER { get; set; }

    [ForeignKey("NMASTERORDER")]
    public Insudb.MASTERCL_ORDER? MASTERCL_ORDER { get; set; }
    public int? NPHYSICIAN { get; set; }
    public int? NMEDICALINSTITUTE { get; set; }
    public int? NREVALIDATIONS { get; set; }
    public string? SPROLTREATMENT { get; set; }
    public DateTime? DPROLTREATFROM { get; set; }
    public DateTime? DPROLTREATTO { get; set; }
    public DateTime? DORIGINALPREAUTH { get; set; }
    public DateTime? DLASTPREAUTH { get; set; }
    public int? NIDMEDICALFEE { get; set; }
    public int? NCASE_NUM_ORIG { get; set; }
    public int? NDEMAN_TYPE_ORIG { get; set; }
    public long? NORDER_NUM_ORIG { get; set; }
    public int? NAUDITDOCTOR { get; set; }
    public string? SCALLCENTER { get; set; }
    public int? NDOCTORROL { get; set; }

    [ForeignKey("NDOCTORROL")]
    public Insudb.TABLE8607? TABLE8607 { get; set; }
    public string? SFASTMEDICALEVAL { get; set; }
    public string? SOBSV_AUDITDOC { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public string? SCLIENT_BENEF { get; set; }
    public string? SCLIENT_REP { get; set; }
    public int? NCLA_LI_TYP { get; set; }

    [ForeignKey("NCLA_LI_TYP")]
    public Insudb.TABLE210? TABLE210 { get; set; }
    public int? NIND_REOPENCL { get; set; }
    public int? NCAUSEREOPENCL { get; set; }
    public int? NTYPE_COMMPAY { get; set; }
    public long? NORDER_NUM_GEN { get; set; }
    public int? NCOMMERCIALPAYASSOC { get; set; }

    [ForeignKey("NCOMMERCIALPAYASSOC")]
    public Insudb.CL_COMMERTYPEPAY? CL_COMMERTYPEPAY { get; set; }
    public string? SHISTORICAL_CLAIM { get; set; }
    public int? NCOUNTRY { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
}
