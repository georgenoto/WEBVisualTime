namespace WEBVisualTime.Servicios.Insudb.DTOs.MASSIVE_RULES;

public class CreateMASSIVE_RULESDto
{
    public long NERRORNUM { get; set; }
    public string SERRORTYP { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SBREAK { get; set; }
    public string? SENABLED { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NACTIONPROC { get; set; }
    public string? SVIP { get; set; }
    public string? STYP_CONDI { get; set; }
    public int NSECTION { get; set; }
}
