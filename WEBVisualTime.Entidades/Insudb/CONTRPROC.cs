#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CONTRPROC
{
    public int NNUMBER { get; set; }

    [ForeignKey("NNUMBER")]
    public Insudb.CONTRMASTER? CONTRMASTERNNUMBER { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CONTRMASTER? CONTRMASTERNBRANCH { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int NTYPE_REL { get; set; }

    [ForeignKey("NTYPE_REL")]
    public Insudb.CONTRMASTER? CONTRMASTERNTYPE_REL { get; set; }
    public int NFQCY_ACC { get; set; }

    [ForeignKey("NFQCY_ACC")]
    public Insudb.TABLE97? TABLE97 { get; set; }
    public string? SCAP_NOM_RI { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NEXCESS { get; set; }
    public decimal? NEXPENSES { get; set; }
    public long? NFACT_RESER { get; set; }
    public decimal? NFIXED_PRAT { get; set; }
    public long? NGROUP_BENE { get; set; }
    public long? NGROUP_CO { get; set; }
    public decimal? NINT_CLAIM { get; set; }
    public decimal? NINT_PREM { get; set; }
    public decimal? NLINES { get; set; }
    public decimal? NMAX_EVEN { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPREM_DEP { get; set; }
    public decimal? NPROFIT_SH { get; set; }
    public decimal? NQUOTA_SHA { get; set; }
    public decimal? NRATE_CLAIM { get; set; }
    public string? SRESER_CLAI { get; set; }
    public decimal? NRETEN_MIN { get; set; }
    public long? NTAB_COMMI { get; set; }
    public string? STAB_LIMIT { get; set; }
    public decimal? NTRAN_PREM { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NYEAR_BEGIN { get; set; }
    public int? NYEAR_END { get; set; }
    public string SRETCOVER { get; set; }
    public string SLIMITCOV { get; set; }
    public string SCESSPRCOV { get; set; }
    public string SEXTRAPREM { get; set; }
    public string SGENCESS { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NCESSPRFIX { get; set; }
    public decimal? NMINCAPCESS { get; set; }
    public int? NNEXTMONTHP { get; set; }
    public int? NNEXTYEARP { get; set; }
    public int? NNEXTMONTHC { get; set; }
    public int? NNEXTYEARC { get; set; }
    public string? SROUPROFIT { get; set; }
    public string? SCOMMCOV { get; set; }
    public decimal? NINTEREST { get; set; }
    public string? SCUMULTYP { get; set; }

    [ForeignKey("SCUMULTYP")]
    public Insudb.TABLE79? TABLE79 { get; set; }
    public string? SCUMREINT { get; set; }

    [ForeignKey("SCUMREINT")]
    public Insudb.TABLE90? TABLE90 { get; set; }
    public string? SCUMULPOL { get; set; }
    public int NFREQPAY { get; set; }

    [ForeignKey("NFREQPAY")]
    public Insudb.TABLE36? TABLE36 { get; set; }
    public int? NNEXTMONTHPA { get; set; }
    public int? NNEXTYEARPA { get; set; }
    public string? SRETZONE { get; set; }
    public string? SCESSCIA { get; set; }
    public long? NIND_AGE { get; set; }
    public string? SROUCESS { get; set; }
    public decimal? NMAXRETAMOUNT { get; set; }
    public string? SDESCRIPT { get; set; }
}
