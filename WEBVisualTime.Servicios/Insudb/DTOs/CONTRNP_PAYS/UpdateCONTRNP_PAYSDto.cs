namespace WEBVisualTime.Servicios.Insudb.DTOs.CONTRNP_PAYS;

public class UpdateCONTRNP_PAYSDto
{
    public int NBRANCH_REI { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NNUMBER { get; set; }
    public int NTYPE { get; set; }
    public int NMONTH { get; set; }
    public int NYEAR { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SCUENTECN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
