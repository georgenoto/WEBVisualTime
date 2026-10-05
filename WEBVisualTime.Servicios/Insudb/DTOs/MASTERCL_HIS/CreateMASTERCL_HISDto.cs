namespace WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_HIS;

public class CreateMASTERCL_HISDto
{
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int NSTATORDER_MAST { get; set; }
    public int NATTENTCHANNEL { get; set; }
    public int NTYPEDOC_PAY { get; set; }
    public int? NCURREN_DOC { get; set; }
    public int? NCURREN_ORDER { get; set; }
    public int? NPROVIDER { get; set; }
    public string? STYPECARE { get; set; }
    public string? SCARECLASS { get; set; }
    public string? SIND_REV { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int NMOVEMENT_TYPE { get; set; }
    public int NTRANSAC { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public int NCLAIMANTTYPE { get; set; }
    public long? NCLAIM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NMASTERORDER_NUM_ORIG { get; set; }
    public long? NMASTERORDER_NUM_GEN { get; set; }
}
