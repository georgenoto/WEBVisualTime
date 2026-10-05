namespace WEBVisualTime.Servicios.Insudb.DTOs.COMMPAYREQ_ORDERS;

public class COMMPAYREQ_ORDERSDto
{
    public long NID_COMMPAYREQ { get; set; }
    public string? COMMPAYMENTREQUESTSSCLIENAME_HOLDER { get; set; }
    public long NCLAIM { get; set; }
    public string? CLAIM_ORDERNCLAIMSTYPECARE { get; set; }
    public int NCASE_NUM { get; set; }
    public string? CLAIM_ORDERNCASE_NUMSTYPECARE { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public string? CLAIM_ORDERNDEMAN_TYPESTYPECARE { get; set; }
    public long NORDER_NUM { get; set; }
    public string? CLAIM_ORDERNORDER_NUMSTYPECARE { get; set; }
    public long NMASTERORDER { get; set; }
    public string? MASTERCL_ORDERSNAMECLIENT { get; set; }
    public int NMASTERORDERTYPE { get; set; }
    public string? TABLE9265SDESCRIPT { get; set; }
    public string? STYPECARE { get; set; }
    public string? TABLE8604SDESCRIPT { get; set; }
    public string? DIAGNOSIS_ORDER { get; set; }
    public string? REASONREJECT_ORDER { get; set; }
    public int NCURRENCY_MO { get; set; }
    public string? TABLE11SDESCRIPT { get; set; }
    public decimal? NAMOUNTREJECTED_ORDER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? USERSSACCESSWO { get; set; }
    public int NSTATUS_ORDER { get; set; }
    public string? TABLE9241SDESCRIPT { get; set; }
}
