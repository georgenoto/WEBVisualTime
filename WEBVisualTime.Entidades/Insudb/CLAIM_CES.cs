#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_CES
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CL_M_COVER? CL_M_COVERNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CL_M_COVER? CL_M_COVERNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.CL_M_COVER? CL_M_COVERNDEMAN_TYPE { get; set; }
    public int NID { get; set; }
    public int NTRANSAC { get; set; }

    [ForeignKey("NTRANSAC")]
    public Insudb.CL_M_COVER? CL_M_COVERNTRANSAC { get; set; }
    public int NNUMBER { get; set; }

    [ForeignKey("NNUMBER")]
    public Insudb.CONTRPROC? CONTRPROCNNUMBER { get; set; }
    public long NCESS_NU { get; set; }
    public int NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.CONTRPROC? CONTRPROCNBRANCH_REI { get; set; }
    public int NNUM_CESS { get; set; }
    public int NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.CL_M_COVER? CL_M_COVERNCURRENCY { get; set; }
    public decimal? NCED_AMNT { get; set; }
    public decimal? NCED_PER { get; set; }
    public int NCESS_CONC { get; set; }

    [ForeignKey("NCESS_CONC")]
    public Insudb.TABLE140? TABLE140 { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public long NCESS_TYPE { get; set; }

    [ForeignKey("NCESS_TYPE")]
    public Insudb.TABLE534? TABLE534 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public DateTime? DEND_DATE { get; set; }
    public DateTime? DINIT_DATE { get; set; }
    public DateTime? DOCCURDATE { get; set; }
    public long? NPOLICY { get; set; }
    public string? SPRINT_C { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DEFFECDATE { get; set; }

    [ForeignKey("DEFFECDATE")]
    public Insudb.CONTRPROC? CONTRPROCDEFFECDATE { get; set; }
    public int NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public int NMODULEC { get; set; }

    [ForeignKey("NMODULEC")]
    public Insudb.CL_M_COVER? CL_M_COVERNMODULEC { get; set; }
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CL_M_COVER? CL_M_COVERSCLIENT { get; set; }
    public int NCOVER { get; set; }

    [ForeignKey("NCOVER")]
    public Insudb.CL_M_COVER? CL_M_COVERNCOVER { get; set; }
    public long NYEARMONTH { get; set; }
    public int? NGROUP_INSU { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.CONTRPROC? CONTRPROCNTYPE { get; set; }
    public string? SSTACLAIM { get; set; }
    public decimal? NRET_AMNT { get; set; }
    public decimal? NCLA_AMNT { get; set; }
    public DateTime? DCLAIM_PAY { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public DateTime? DPOSTED { get; set; }
}
