namespace WEBVisualTime.Servicios.Insudb.DTOs.PROD_ADDCAP;

public class CreatePROD_ADDCAPDto
{
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NROLE { get; set; }
    public decimal? NCAPITAL { get; set; }
    public int? NCOVERADD { get; set; }
    public int? NROLEADD { get; set; }
    public int NTYP_CUMUL { get; set; }
}
