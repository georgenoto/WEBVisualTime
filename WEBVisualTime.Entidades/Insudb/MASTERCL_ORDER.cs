#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASTERCL_ORDER
{
    public long NMASTERORDER { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string SNAMECLIENT { get; set; }
    public int? NPROVIDER { get; set; }
    public int? NATTENTCHANNEL { get; set; }
    public DateTime? DACCOUNTDOC { get; set; }
    public int? NTYPEDOC_PAY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NSTATORDER_MAST { get; set; }

    [ForeignKey("NSTATORDER_MAST")]
    public Insudb.TABLE9264? TABLE9264 { get; set; }
    public long? NNOTENUM { get; set; }
    public DateTime DORDERDATE { get; set; }
    public int? NUSER_AMEND { get; set; }
    public int? NUSER_AUDITDOC { get; set; }
    public int? NUSER_DERIVEDBY { get; set; }
    public int NMASTERORDERTYPE { get; set; }

    [ForeignKey("NMASTERORDERTYPE")]
    public Insudb.TABLE9265? TABLE9265 { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public int NCLAIMANTTYPE { get; set; }

    [ForeignKey("NCLAIMANTTYPE")]
    public Insudb.TABLE9212? TABLE9212 { get; set; }
    public int? NREVALIDATIONS { get; set; }
    public DateTime? DORIGINALPREAUTH { get; set; }
    public DateTime? DLASTPREAUTH { get; set; }
    public string? STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public string? SCARECLASS { get; set; }

    [ForeignKey("SCARECLASS")]
    public Insudb.TABLE8605? TABLE8605 { get; set; }
    public int? NCURREN_DOC { get; set; }
    public int? NCURREN_ORDER { get; set; }
    public string? SCALLCENTER { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DPRESENTDATE { get; set; }
    public long? NCLAIM { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE9263? TABLE9263 { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public int NCLA_LI_TYP { get; set; }

    [ForeignKey("NCLA_LI_TYP")]
    public Insudb.TABLE210? TABLE210 { get; set; }
    public int? NIND_REOPENCL { get; set; }
    public int? NCAUSEREOPENCL { get; set; }
    public int? NTYPE_COMMPAY { get; set; }
    public long? NMASTERORDER_NUM_ORIG { get; set; }
    public long? NMASTERORDEN_NUM_GEN { get; set; }
    public string? SHISTORICAL_CLAIM { get; set; }
    public int? NCOUNTRY { get; set; }
    public long? NSEQUENCE_ID { get; set; }
}
