namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;

public class CreateCOMMPAYREQ_ORDERSDto
{
    public long? NMASTERORDER { get; set; }
    public int? NMASTERORDERTYPE { get; set; }
    public string? STYPECARE { get; set; }
    public string? DIAGNOSIS_ORDER { get; set; }
    public string? REASONREJECT_ORDER { get; set; }
    public long? NCURRENCY_MO { get; set; }
    public decimal? NAMOUNTREJECTED_ORDER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NSTATUS_ORDER { get; set; }
}
