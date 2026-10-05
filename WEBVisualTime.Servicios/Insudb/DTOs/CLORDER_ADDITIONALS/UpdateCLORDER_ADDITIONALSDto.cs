namespace WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_ADDITIONALS;

public class UpdateCLORDER_ADDITIONALSDto
{
    public long NCLAIM { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public long NORDER_NUM { get; set; }
    public int NADDITIONAL_ORDER { get; set; }
    public string? SMEDICATION { get; set; }
    public int? NQUANTITYOFMEDICATION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
}
