namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYMENTREQUESTS;

public class UpdateCOMMPAYMENTREQUESTSDto
{
    public long NID_COMMPAYREQ { get; set; }
    public DateTime? DREGISTRATIONDATE { get; set; }
    public int? NOFFICE { get; set; }
    public string? SCLIENT_HOLDER { get; set; }
    public string? SCLIENAME_HOLDER { get; set; }
    public string? SCLIENT_INSURED { get; set; }
    public string? SCLIENAME_INSURED { get; set; }
    public string? SCLIENT_AFFECT { get; set; }
    public string? SCLIENAME_AFFECT { get; set; }
    public int? NAGE_AFFECT { get; set; }
    public int? NROLE { get; set; }
    public DateTime? DINSURENTRYDATE { get; set; }
    public DateTime DOCCURDAT { get; set; }
    public long NIDPRECLAIM { get; set; }
    public string? STYPECARE_PRECLAIM { get; set; }
    public long? NCLAIM { get; set; }
    public DateTime? DREJECTEDDATE { get; set; }
    public decimal? NAMOUNTREJECTED_PRECLAIM { get; set; }
    public long? NCURRENCY { get; set; }
    public string? DIAGNOSIS_PRECLAIM { get; set; }
    public string? REASONREJECT_PRECLAIM { get; set; }
    public string? SCLARIFICATIONREQUESTED { get; set; }
    public string? SJUSTIFICATIONREQUESTED { get; set; }
    public int? NUSERCODE_RESPONSIBLE { get; set; }
    public DateTime? DRESULTDATE { get; set; }
    public string? SIND_RESULT { get; set; }
    public string? SIND_ASSUMEIVA { get; set; }
    public long? NCURRENCY_PAY { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NPERCENTPAY { get; set; }
    public string? SOBSERVATIONSRESULT { get; set; }
    public string? SCLIENAME_AUTHORIZER1 { get; set; }
    public string? SPOSITION_AUTHORIZER1 { get; set; }
    public string? SCLIENAME_AUTHORIZER2 { get; set; }
    public string? SPOSITION_AUTHORIZER2 { get; set; }
    public DateTime? DLETTERDATE { get; set; }
    public long? NNUMBERLETTER { get; set; }
    public string? SADDRESSEDTO { get; set; }
    public int NSTATUS { get; set; }
    public long? NNOTENUM { get; set; }
    public int? NMOVEMENT { get; set; }
    public int? NUSER_AMEND { get; set; }
    public int? NUSER_DERIVEDBY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNULLCODE { get; set; }
}
