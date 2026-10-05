namespace WEBVisualTime.Servicios.Insudb.DTOs.MASTERCL_DETAIL;

public class CreateMASTERCL_DETAILDto
{
    public int NORD_PROCEDURE { get; set; }
    public int? NID { get; set; }
    public string? SBENEFIT { get; set; }
    public string? SSAME_INCISION { get; set; }
    public int? NPERCENTAGE_PROC { get; set; }
    public string? SILLNESS { get; set; }
    public int? NCOD_REJECT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SREJECTALERT { get; set; }
    public int? NAPPLY_EXCLU { get; set; }
    public string? SILLNES_DETECT { get; set; }
    public int? NACCEPT_EVALMED { get; set; }
    public string? SMEDICAL_REJEC { get; set; }
    public string? SREJECTOBSV { get; set; }
    public long? NORDER_NUM { get; set; }
    public int? NRELPROCEDURE_ID { get; set; }
    public decimal? NBALANCE { get; set; }
    public decimal? NAMOUNT_DOCU { get; set; }
    public decimal? NAMOUNT_ORDEN { get; set; }
    public int? NPERCEN_COVERAGE { get; set; }
    public int? NQUANTITY { get; set; }
    public int? NIND_DONOTRECALCULATE { get; set; }
    public decimal? NAMOUNT_DIFFERENCETARIFF { get; set; }
    public int? NIND_REOPENCL { get; set; }
    public int NCAUSEREOPENCL { get; set; }
    public int? NTYPE_COMMPAY { get; set; }
    public long? NRELPROCEDURE_NUM_ORIG { get; set; }
    public long? NRELPROCEDURE_NUM_GEN { get; set; }
}
