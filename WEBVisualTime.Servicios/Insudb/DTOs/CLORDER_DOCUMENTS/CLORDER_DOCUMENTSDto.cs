namespace WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_DOCUMENTS;

public class CLORDER_DOCUMENTSDto
{
    public long NCLAIM { get; set; }
    public string? DOCUMENTSNCLAIMSDESCRIPT { get; set; }
    public int NCASE_NUM { get; set; }
    public string? DOCUMENTSNCASE_NUMSDESCRIPT { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public string? TABLE692SDESCRIPT { get; set; }
    public string SCLIENT { get; set; }
    public string? DOCUMENTSSCLIENTSDESCRIPT { get; set; }
    public int NID { get; set; }
    public string? DOCUMENTSNIDSDESCRIPT { get; set; }
    public int NDOC_CODE { get; set; }
    public string? DOCUMENTSNDOC_CODESDESCRIPT { get; set; }
    public long NCONSEC { get; set; }
    public string? DOCUMENTSNCONSECSDESCRIPT { get; set; }
    public long NORDER_NUM { get; set; }
    public long NCONSEC_ORDERDOC { get; set; }
    public int NAPPLY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
