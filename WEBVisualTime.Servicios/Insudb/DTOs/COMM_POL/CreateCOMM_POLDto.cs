namespace WEBVisualTime.Servicios.Insudb.DTOs.COMM_POL;

public class CreateCOMM_POLDto
{
    public int NTYPMOV_COMM { get; set; }
    public string? STYP_COMM { get; set; }
    public decimal NTOTAL_COM { get; set; }
    public int NINSTALLMENTS { get; set; }
    public int NPEN_INSTALL { get; set; }
    public decimal NINSTALL_AMO { get; set; }
    public long? NPAY_COMM { get; set; }
    public long? NCURR_ACC { get; set; }
    public decimal NAVAILABLE { get; set; }
    public decimal? NAVAIL_AFEC { get; set; }
    public decimal? NAVAIL_EXEN { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NSTATUS_COMM { get; set; }
    public string? STYPEDOCU { get; set; }
    public long? NDOCUMENT { get; set; }
    public int? NDRAFT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTRATYPEI { get; set; }
    public int? NTYPE { get; set; }
    public long? NTRANSAC { get; set; }
    public int? NMAINYEAR_COMM { get; set; }
    public long? NRECEIPT { get; set; }
    public decimal? NPERCADV_PAY { get; set; }
    public DateTime? DACCRUALDATE { get; set; }
    public decimal? NPREMIUMN_AN { get; set; }
    public decimal? NPREMIUM_AN { get; set; }
    public decimal? NBALANCE { get; set; }
    public string? SIND_DESC { get; set; }
    public string? SIND_BALANCE { get; set; }
    public int? NCOD_SALDIS { get; set; }
    public int? NCATEGORY { get; set; }
    public int? NID_CAMPAIGN { get; set; }
    public DateTime? DDATEEND_CAMP { get; set; }
}
