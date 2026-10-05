#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DOCUMENTS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIMBENEF? CLAIMBENEFNCLAIM { get; set; }
    public int NDOC_CODE { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CLAIMBENEF? CLAIMBENEFNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLAIMBENEF? CLAIMBENEFSCLIENT { get; set; }
    public int NID { get; set; }

    [ForeignKey("NID")]
    public Insudb.CLAIMBENEF? CLAIMBENEFNID { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public DateTime? DLETFIRSDAT { get; set; }
    public DateTime? DLETLASTDAT { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public int NSTATUS_DOC { get; set; }

    [ForeignKey("NSTATUS_DOC")]
    public Insudb.TABLE203? TABLE203 { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public long? NDOCNUMBE { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime DPROPO_DATE { get; set; }
    public DateTime DPRESCDATE { get; set; }
    public long NCONSEC { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public int NDOC_TYPE { get; set; }

    [ForeignKey("NDOC_TYPE")]
    public Insudb.TABLE9217? TABLE9217 { get; set; }
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int? NCLASS_DOC { get; set; }
    public string? SOBSERVATIONS { get; set; }
}
