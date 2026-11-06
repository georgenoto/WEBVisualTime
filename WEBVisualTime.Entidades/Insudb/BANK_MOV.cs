#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BANK_MOV
{
    public string? SDEP_NUMBER { get; set; }
    public string? SNULL_MOVEM { get; set; }
    public string? SNULL_RECOR { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DDOC_DATE { get; set; }
    public decimal? NCASH_AMOUN { get; set; }
    public decimal? NCHEQ_AMOUN { get; set; }
    public long NMOVEMENT { get; set; }
    public long? NYEAR_MONTH { get; set; }
    public long? NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public string? SDOCNUMBE { get; set; }
    public int? NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE22? TABLE22 { get; set; }
    public int NACC_BANK { get; set; }

    [ForeignKey("NACC_BANK")]
    public Insudb.BANK_ACC? BANK_ACC { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int? NTYPE_MOV { get; set; }

    [ForeignKey("NTYPE_MOV")]
    public Insudb.TABLE296? TABLE296 { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SNUMFORM { get; set; }
    public long? NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public int? NVOUCHER_LE { get; set; }
    public long? NCONTRAT { get; set; }

    [ForeignKey("NCONTRAT, NDRAFT")]
    public Insudb.FINANC_DRA? FINANC_DRANCONTRAT { get; set; }
    public int? NDRAFT { get; set; }

    [NotMapped]
    public Insudb.FINANC_DRA? FINANC_DRANDRAFT
    {
        get => FINANC_DRANCONTRAT;
        set => FINANC_DRANCONTRAT = value;
    }
    public int? NCOMPANYC { get; set; }
    public long? NVOUCHER { get; set; }
    public int? NTYP_ACCO { get; set; }

    [ForeignKey("NTYP_ACCO")]
    public Insudb.TABLE400? TABLE400 { get; set; }
    public string? STYPE_ACC { get; set; }
    public int NCASHNUM { get; set; }
    public DateTime? DPOSTED { get; set; }
    public long? NNOTENUM { get; set; }
    public long NID { get; set; }
    public int? NINSUR_AREA { get; set; }
    public DateTime? DCOLLECTION { get; set; }
    public long? NPROPONUM { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int? NORI_CURR { get; set; }
    public decimal? NORI_AMOUNT { get; set; }
    public long? NSUPPORT_ID { get; set; }
    public int? NTYPESUPPORT { get; set; }
    public long? NCASH_ID { get; set; }
    public int? NCOD_AGREE { get; set; }
    public long? NBANK_AGREE { get; set; }
    public int? NINPUTCHANNEL { get; set; }
    public long? NBORDERUSED { get; set; }
    public DateTime? DREALDEP { get; set; }
    public decimal? NAMOUNTDEC { get; set; }
    public DateTime? DVALUEDATE { get; set; }
}
