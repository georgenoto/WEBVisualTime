namespace WEBVisualTime.Servicios.Insudb.DTOs.STIPEND_POL;

public class UpdateSTIPEND_POLDto
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NROLE { get; set; }
    public string SCLIENT { get; set; }
    public int NTYPE_CONTRAT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCOMMITYP { get; set; }
    public long? NCONTRAT_PAY { get; set; }
    public long? NINTERMED { get; set; }
    public decimal? NAMOUNT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPERCENT { get; set; }
    public decimal? NSHARE { get; set; }
}
