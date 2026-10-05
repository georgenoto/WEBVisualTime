namespace WEBVisualTime.Servicios.Insudb.DTOs.BATCH_PARAM_VALUE;

public class BATCH_PARAM_VALUEDto
{
    public string SKEY { get; set; }
    public string? BATCH_JOBSCOMMAND { get; set; }
    public int NAREA { get; set; }
    public string? BATCH_PARAMNAREASNAME { get; set; }
    public int NSEQ { get; set; }
    public string? BATCH_PARAMNSEQSNAME { get; set; }
    public int NBATCH { get; set; }
    public string? BATCH_PARAMNBATCHSNAME { get; set; }
    public string? SVALUE { get; set; }
    public int? NDATATYPE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
}
