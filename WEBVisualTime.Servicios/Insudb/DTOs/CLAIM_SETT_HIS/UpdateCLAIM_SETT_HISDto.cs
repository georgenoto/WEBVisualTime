namespace WEBVisualTime.Servicios.Insudb.DTOs.CLAIM_SETT_HIS;

public class UpdateCLAIM_SETT_HISDto
{
    public long NSETTLEMENT_NUM { get; set; }
    public int NTRANSAC { get; set; }
    public DateTime DOPERDATE { get; set; }
    public int? NPAYMENT_METHOD { get; set; }
    public int? NPAYEE { get; set; }
    public int? NSETTLEMENT_STAT { get; set; }
    public int? NSETTLEMENT_CONC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SREMARKS { get; set; }
    public int? NMOVEMENT_TYPE { get; set; }
    public int? NNULLCODE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NREQUEST_NU { get; set; }
}
