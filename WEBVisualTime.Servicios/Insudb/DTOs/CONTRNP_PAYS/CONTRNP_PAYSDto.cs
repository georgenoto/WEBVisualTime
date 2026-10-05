namespace WEBVisualTime.Servicios.Insudb.DTOs.CONTRNP_PAYS;

public class CONTRNP_PAYSDto
{
    public int NBRANCH_REI { get; set; }
    public string? CONTRNPRONBRANCH_REISDESCRIPT { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? CONTRNPRODEFFECDATESDESCRIPT { get; set; }
    public int NNUMBER { get; set; }
    public string? CONTRNPRONNUMBERSDESCRIPT { get; set; }
    public int NTYPE { get; set; }
    public string? CONTRNPRONTYPESDESCRIPT { get; set; }
    public int NMONTH { get; set; }
    public int NYEAR { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SCUENTECN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
