namespace WEBVisualTime.Servicios.Insudb.DTOs.MASS_PROC_SPONSOR;

public class UpdateMASS_PROC_SPONSORDto
{
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NPROCESS { get; set; }
    public string SKEY { get; set; }
    public string? SLOT { get; set; }
    public string? STYPEEXECUTION { get; set; }
    public long? NSTATUS { get; set; }
    public DateTime? DPROCESSDATE { get; set; }
    public long? NTOTALRECPROC { get; set; }
    public long? NSUCCESSRECPROC { get; set; }
    public long? NERRORRECPROC { get; set; }
    public decimal? NCOLLECTPREMIUM { get; set; }
    public long? NSUSCRIBEDPOLICIES { get; set; }
    public long? NCANCELEDPOLICIES { get; set; }
    public long? NMODIFIEDPOLICIES { get; set; }
    public long? NCLAIMSREPORTED { get; set; }
    public long? NDECLAREDCLAIMS { get; set; }
    public decimal? NTOTALCLAIMSPAID { get; set; }
    public long? NCLAIMSPAID { get; set; }
    public long? NCANCELEDCLAIMS { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NKEY { get; set; }
    public long? NCANCELEDCERTIFICATE { get; set; }
    public long? NMODIFIEDCERTIFICATE { get; set; }
    public long? NPOLICY { get; set; }
    public long? NSUSCRIBEDCERTIFICATE { get; set; }
    public int? NSHEET_OUT { get; set; }
    public int? NUSERINCHARGE { get; set; }
    public DateTime? DRECEPTION_DAY { get; set; }
    public long NCOD_AGREE { get; set; }
    public string? SFILENAME { get; set; }
    public DateTime DEXECUTE { get; set; }
    public int? NMONTH { get; set; }
    public int? NYEAR { get; set; }
}
