namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_PRESCRIPTION;

public class UpdateCLAIM_PRESCRIPTIONDto
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMONTHS { get; set; }
    public int NDAYS { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int NCLA_LI_TYP { get; set; }
}
