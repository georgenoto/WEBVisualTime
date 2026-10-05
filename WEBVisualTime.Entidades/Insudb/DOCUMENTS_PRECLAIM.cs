#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DOCUMENTS_PRECLAIM
{
    public long NIDPRECLAIM { get; set; }
    public long NCONSEC { get; set; }
    public int NDOC_CODE { get; set; }
    public long NDOCNUMBE { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public DateTime? DPROPO_DATE { get; set; }
    public DateTime? DPRESCDATE { get; set; }
    public int NSTATUS_DOC { get; set; }

    [ForeignKey("NSTATUS_DOC")]
    public Insudb.TABLE203? TABLE203 { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NQUANTITY { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NDOC_TYPE { get; set; }

    [ForeignKey("NDOC_TYPE")]
    public Insudb.TABLE9217? TABLE9217 { get; set; }
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int NCLASS_DOC { get; set; }

    [ForeignKey("NCLASS_DOC")]
    public Insudb.TABLE9219? TABLE9219 { get; set; }
    public string? SOBSERVATIONS { get; set; }
}
