namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_FEES;

public class UpdateTAB_PROV_FEESDto
{
    public int NPROVIDER { get; set; }
    public int NZONE { get; set; }
    public string STYPEBENEFIT { get; set; }
    public string SBENEFITCLAS { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal NDISC_FEE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
