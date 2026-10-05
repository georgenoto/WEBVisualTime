namespace WEBVisualTime.Servicios.Insudb.DTOs.DOCUMENTS;

public class CreateDOCUMENTSDto
{
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public DateTime? DLETFIRSDAT { get; set; }
    public DateTime? DLETLASTDAT { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public int NSTATUS_DOC { get; set; }
    public int NUSERCODE { get; set; }
    public long? NDOCNUMBE { get; set; }
    public int? NQUANTITY { get; set; }
    public DateTime DPROPO_DATE { get; set; }
    public DateTime DPRESCDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public int NDOC_TYPE { get; set; }
    public int NPROVIDER { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int? NCLASS_DOC { get; set; }
    public string? SOBSERVATIONS { get; set; }
}
