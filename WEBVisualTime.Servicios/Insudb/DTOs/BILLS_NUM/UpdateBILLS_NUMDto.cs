namespace WEBVisualTime.Servicios.Insudb.DTOs.BILLS_NUM;

public class UpdateBILLS_NUMDto
{
    public int NINSUR_AREA { get; set; }
    public string SBILLTYPE { get; set; }
    public long NINITNUMB { get; set; }
    public long NENDNUMB { get; set; }
    public long NLASTBILL { get; set; }
    public DateTime DLASTCLOSED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
