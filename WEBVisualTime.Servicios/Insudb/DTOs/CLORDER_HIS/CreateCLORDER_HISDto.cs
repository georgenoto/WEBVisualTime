namespace WEBVisualTime.Servicios.Insudb.DTOs.CLORDER_HIS;

public class CreateCLORDER_HISDto
{
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int NSTATUS_ORDER { get; set; }
    public int NATTENTCHANNEL { get; set; }
    public int NTYPEDOC_PAY { get; set; }
    public int NCURREN_DOC { get; set; }
    public int NCURREN_ORDER { get; set; }
    public int? NPROVIDER { get; set; }
    public string? STYPECARE { get; set; }
    public string? SIND_REV { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int? DPOSTED { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NMOVEMENT_TYPE { get; set; }
    public string? SCARECLASS { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public string? SPROLTREATMENT { get; set; }
    public int? NPHYSICIAN { get; set; }
    public int? NMEDICALINSTITUTE { get; set; }
    public int? NCLAIMANTTYPE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NORDER_NUM_ORIG { get; set; }
    public long? NORDER_NUM_GEN { get; set; }
}
