namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;

public class UpdateCOMMPAYREQ_ORDERSDto
{
    public long NID_COMMPAYREQ { get; set; }
    public long NCLAIM { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public long NORDER_NUM { get; set; }
    public long NMASTERORDER { get; set; }
    public int NMASTERORDERTYPE { get; set; }
    public string? STYPECARE { get; set; }
    public string? DIAGNOSIS_ORDER { get; set; }
    public string? REASONREJECT_ORDER { get; set; }
    public int NCURRENCY_MO { get; set; }
    public decimal? NAMOUNTREJECTED_ORDER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NSTATUS_ORDER { get; set; }
}
