namespace WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS_PRECLAIM;

public class CreateDOCUMENTS_PRECLAIMDto
{
    public int NDOC_CODE { get; set; }
    public long NDOCNUMBE { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public DateTime? DPROPO_DATE { get; set; }
    public DateTime? DPRESCDATE { get; set; }
    public int NSTATUS_DOC { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public int? NQUANTITY { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NDOC_TYPE { get; set; }
    public int NPROVIDER { get; set; }
    public string? SCLIENT { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int NCLASS_DOC { get; set; }
    public string? SOBSERVATIONS { get; set; }
}
