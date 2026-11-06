namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_POLICIES;

public class UpdateCOMMPAYREQ_POLICIESDto
{
    public long NID_COMMPAYREQ { get; set; }
    public int NCONSEC { get; set; }
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NMODULEC { get; set; }
    public int? NGROUP_INSU { get; set; }
    public string SPOLITYPE { get; set; }
    public int? NIND_POLICY { get; set; }
    public int? NIND_CURRENT_POLICY { get; set; }
    public long? NINTERMED { get; set; }
    public int? NINTERTYP { get; set; }
    public string? SCLIENAME_INTERMEDIA { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public DateTime DEXPIRDAT { get; set; }
    public long NCURRENCY { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NBALANCECAPITAL { get; set; }
    public decimal? NBALANCEDEDUC { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NPREMIUMN { get; set; }
    public decimal? NPREMIUMNPAID { get; set; }
    public decimal? NCLAIMSAMOUNTBASE_SETT { get; set; }
    public decimal? NCLAIMSAMOUNTBASE_PEND { get; set; }
    public int? NRATECLAIMS { get; set; }
    public int? NRATEPROFIT { get; set; }
    public int? NRATEPROJECTED_CLAIMS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
