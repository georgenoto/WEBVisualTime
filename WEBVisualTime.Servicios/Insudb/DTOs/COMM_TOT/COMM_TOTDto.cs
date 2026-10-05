namespace WEBVisualTime.Servicios.Insudb.DTOs.COMM_TOT;

public class COMM_TOTDto
{
    public long NINTERMED { get; set; }
    public string? INTERMEDIASCOL_AGREE { get; set; }
    public int? NRECEIPT { get; set; }
    public string? SCERTYPE { get; set; }
    public string? CERTIFICATSCERTYPESCUMUL_CODE { get; set; }
    public int NBRANCH { get; set; }
    public string? CERTIFICATNBRANCHSCUMUL_CODE { get; set; }
    public int NPRODUCT { get; set; }
    public string? CERTIFICATNPRODUCTSCUMUL_CODE { get; set; }
    public long NPOLICY { get; set; }
    public string? CERTIFICATNPOLICYSCUMUL_CODE { get; set; }
    public long NCERTIF { get; set; }
    public string? CERTIFICATNCERTIFSCUMUL_CODE { get; set; }
    public int? NDIGIT { get; set; }
    public int? NPAYNUMBE { get; set; }
    public long NCOMM { get; set; }
    public long? NMOVNUMBE { get; set; }
    public decimal? NTOTALPREMIUM { get; set; }
    public decimal? NTOTALCOMM { get; set; }
}
