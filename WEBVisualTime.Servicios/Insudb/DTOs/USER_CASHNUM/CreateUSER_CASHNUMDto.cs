namespace WEBVisualTime.Servicios.Insudb.DTOs.USER_CASHNUM;

public class CreateUSER_CASHNUMDto
{
    public string SSTATUS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSER { get; set; }
    public int NUSERCODE { get; set; }
    public int? NCASHSUP { get; set; }
    public int? NHEADSUP { get; set; }
    public int NOFFICEAGEN { get; set; }
    public int? NTYPECASH { get; set; }
}
