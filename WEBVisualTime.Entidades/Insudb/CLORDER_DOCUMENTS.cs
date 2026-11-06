#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLORDER_DOCUMENTS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM, NDOC_CODE, NCASE_NUM, NDEMAN_TYPE, SCLIENT, NID, NCONSEC")]
    public Insudb.DOCUMENTS? DOCUMENTSNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [NotMapped]
    public Insudb.DOCUMENTS? DOCUMENTSNCASE_NUM
    {
        get => DOCUMENTSNCLAIM;
        set => DOCUMENTSNCLAIM = value;
    }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public string SCLIENT { get; set; }

    [NotMapped]
    public Insudb.DOCUMENTS? DOCUMENTSSCLIENT
    {
        get => DOCUMENTSNCLAIM;
        set => DOCUMENTSNCLAIM = value;
    }
    public int NID { get; set; }

    [NotMapped]
    public Insudb.DOCUMENTS? DOCUMENTSNID
    {
        get => DOCUMENTSNCLAIM;
        set => DOCUMENTSNCLAIM = value;
    }
    public int NDOC_CODE { get; set; }

    [NotMapped]
    public Insudb.DOCUMENTS? DOCUMENTSNDOC_CODE
    {
        get => DOCUMENTSNCLAIM;
        set => DOCUMENTSNCLAIM = value;
    }
    public long NCONSEC { get; set; }

    [NotMapped]
    public Insudb.DOCUMENTS? DOCUMENTSNCONSEC
    {
        get => DOCUMENTSNCLAIM;
        set => DOCUMENTSNCLAIM = value;
    }
    public long NORDER_NUM { get; set; }
    public long NCONSEC_ORDERDOC { get; set; }
    public int NAPPLY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
