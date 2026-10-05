namespace WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM_VALUE;

public class UpdateBATCH_PARAM_VALUEDto
{
    public string SKEY { get; set; }
    public int NAREA { get; set; }
    public int NSEQ { get; set; }
    public int NBATCH { get; set; }
    public string? SVALUE { get; set; }
    public int? NDATATYPE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
}
