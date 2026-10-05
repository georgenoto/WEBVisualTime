namespace WEBVisualTime.Servicios.Insudb.DTOs.BRANPROD_ALLOW;

public class UpdateBRANPROD_ALLOWDto
{
    public long NINTERMED { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NMODULEC { get; set; }
    public int NINSTALLMENTS { get; set; }
    public int NSTARTMONTH { get; set; }
    public int NENDMONTH { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NNOTE_INT { get; set; }
    public int NCATEGORY { get; set; }
}
