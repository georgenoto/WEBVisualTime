namespace WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_LOG_ERROR;

public class CreateMASSIVE_LOG_ERRORDto
{
    public string SKEY { get; set; }
    public long NKEY { get; set; }
    public long NROW { get; set; }
    public long NSEQ { get; set; }
    public long NCONSEC { get; set; }
    public string? SACTION { get; set; }
    public long? NCODERROR { get; set; }
    public string? SERRORTYP { get; set; }
    public string? STYP_CONDI { get; set; }
    public int? NSECTION { get; set; }
    public string? SCODISPL { get; set; }
    public string? SERRORMESSEROW { get; set; }
    public string? SBREAK { get; set; }
    public long? NCOD_AGREE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NACTION { get; set; }
}
