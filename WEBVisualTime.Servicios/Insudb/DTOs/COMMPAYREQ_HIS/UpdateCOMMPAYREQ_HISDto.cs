namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_HIS;

public class UpdateCOMMPAYREQ_HISDto
{
    public long NID_COMMPAYREQ { get; set; }
    public int NMOVEMENT { get; set; }
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int NMOVEMENT_TYPE { get; set; }
    public int NSTATUS { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCLARIFICATIONREQUESTED { get; set; }
    public string? SJUSTIFICATIONREQUESTED { get; set; }
    public int? NUSERCODE_RESPONSIBLE { get; set; }
    public DateTime? DRESULTDATE { get; set; }
    public string? SIND_RESULT { get; set; }
    public string? SIND_ASSUMEIVA { get; set; }
    public int? NCURRENCY_PAY { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NNULLCODE { get; set; }
}
