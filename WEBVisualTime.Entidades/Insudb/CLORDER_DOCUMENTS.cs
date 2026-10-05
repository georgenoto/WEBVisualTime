#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLORDER_DOCUMENTS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.DOCUMENTS? DOCUMENTSNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.DOCUMENTS? DOCUMENTSNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.DOCUMENTS? DOCUMENTSSCLIENT { get; set; }
    public int NID { get; set; }

    [ForeignKey("NID")]
    public Insudb.DOCUMENTS? DOCUMENTSNID { get; set; }
    public int NDOC_CODE { get; set; }

    [ForeignKey("NDOC_CODE")]
    public Insudb.DOCUMENTS? DOCUMENTSNDOC_CODE { get; set; }
    public long NCONSEC { get; set; }

    [ForeignKey("NCONSEC")]
    public Insudb.DOCUMENTS? DOCUMENTSNCONSEC { get; set; }
    public long NORDER_NUM { get; set; }
    public long NCONSEC_ORDERDOC { get; set; }
    public int NAPPLY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
