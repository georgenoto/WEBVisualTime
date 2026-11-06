#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLORDER_DETAIL
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM, NCASE_NUM, NDEMAN_TYPE, NORDER_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [NotMapped]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCASE_NUM
    {
        get => CLAIM_ORDERNCLAIM;
        set => CLAIM_ORDERNCLAIM = value;
    }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public long NORDER_NUM { get; set; }

    [NotMapped]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNORDER_NUM
    {
        get => CLAIM_ORDERNCLAIM;
        set => CLAIM_ORDERNCLAIM = value;
    }
    public int NDETAIL_ORDER { get; set; }
    public int? NID { get; set; }
    public string? SBENEFIT { get; set; }

    [ForeignKey("SBENEFIT")]
    public Insudb.MEDICALBENEFITS? MEDICALBENEFITS { get; set; }
    public string? VADEMECUM { get; set; }
    public int? NQUANTITY { get; set; }
    public decimal? NAMOUNT_DOCU { get; set; }
    public decimal? NAMOUNT_ORDEN { get; set; }
    public decimal? NAMOUNT_UNITAMV { get; set; }
    public decimal? NAMOUNT_UNITRECAL { get; set; }
    public decimal? NAMOUNT_TOTAL { get; set; }
    public int? NPERCEN_COVERAGE { get; set; }
    public decimal? NAMOUNT_DEDUCOIN { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NCOD_REJECT { get; set; }
    public int? NACCEPT_EVALMED { get; set; }
    public int? NAPPLY_EXCLU { get; set; }
    public string? SILLNES_DETECT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NBALANCE { get; set; }
    public string? SREJECTALERT { get; set; }
    public string? SILLNESS { get; set; }

    [ForeignKey("SILLNESS")]
    public Insudb.TAB_AM_ILL? TAB_AM_ILL { get; set; }
    public decimal? NAMOUNT_PAY_POL { get; set; }
    public string? SMEDSPECIALIALTY { get; set; }

    [ForeignKey("SMEDSPECIALIALTY")]
    public Insudb.TABLE8603? TABLE8603 { get; set; }
    public int? NSURCHAR_MED { get; set; }

    [ForeignKey("NSURCHAR_MED")]
    public Insudb.MEDICAL_SURCHARGE? MEDICAL_SURCHARGE { get; set; }
    public decimal? NPERC_SURCHAR { get; set; }
    public decimal? NAMOUNT_SURCHAR { get; set; }
    public string? SSECONDVISIT { get; set; }
    public decimal? NAMOUNT_UNITAMV_INT { get; set; }
    public string? SMEDICAL_REJEC { get; set; }
    public string? SREJECTOBSV { get; set; }
    public long? NMASTERORDER { get; set; }
    public int? NPROCEDURE_ID { get; set; }
    public decimal? NPERCENTAGE_ROLE { get; set; }
    public int? NIND_DONOTRECALCULATE { get; set; }
    public decimal? NAMOUNT_DIFFERENCETARIFF { get; set; }
    public decimal? NAMOUNT_DEDUCTIBLE { get; set; }
    public decimal? NAMOUNT_DISCOUNTS { get; set; }
    public int? NPERCENT_COV_ORIG { get; set; }
    public decimal? NTOTALAMOUNT_ORDER { get; set; }
}
