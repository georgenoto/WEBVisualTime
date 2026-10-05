namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_DOCUM;

public class UpdateCLAIM_SETT_DOCUMDto
{
    public long? NSEQ_IDLEDGERDOCUM { get; set; }
    public long NCONSEC_DOC { get; set; }
    public DateTime? DRECEPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NSTATUS_DOC { get; set; }
    public int? NDOC_CODE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NSETTLEMENT_NUM { get; set; }
}
