namespace WEBVisualTime.Servicios.Insudb.DTOs.TAB_COMPRO;

public class UpdateTAB_COMPRODto
{
    public int NTYPE_TRAN { get; set; }
    public int NLINE { get; set; }
    public int? NTYP_ACCO { get; set; }
    public string? SDEBITSIDE { get; set; }
    public int? NTYP_AMOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
