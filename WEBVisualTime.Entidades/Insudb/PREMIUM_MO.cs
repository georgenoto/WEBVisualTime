#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PREMIUM_MO
{
    public long NRECEIPT { get; set; }

    [ForeignKey("NRECEIPT")]
    public Insudb.PREMIUM? PREMIUMNRECEIPT { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.PREMIUM? PREMIUMNPRODUCT { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.PREMIUM? PREMIUMNBRANCH { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.PREMIUM? PREMIUMSCERTYPE { get; set; }
    public int NDIGIT { get; set; }

    [ForeignKey("NDIGIT")]
    public Insudb.PREMIUM? PREMIUMNDIGIT { get; set; }
    public int NPAYNUMBE { get; set; }

    [ForeignKey("NPAYNUMBE")]
    public Insudb.PREMIUM? PREMIUMNPAYNUMBE { get; set; }
    public int NTRANSAC { get; set; }
    public decimal? NAMOUNT { get; set; }
    public int NCARD_TYPE { get; set; }

    [ForeignKey("NCARD_TYPE")]
    public Insudb.TABLE183? TABLE183 { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public decimal? NBALANCE { get; set; }
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public long NBORDEREAUX { get; set; }

    [ForeignKey("NBORDEREAUX")]
    public Insudb.COLFORMREF? COLFORMREF { get; set; }
    public DateTime? DCAR_DATEXP { get; set; }
    public string? SCARD_NUM { get; set; }
    public long? NCASH_MOV { get; set; }
    public int NCAUSE_AMEN { get; set; }

    [ForeignKey("NCAUSE_AMEN")]
    public Insudb.TABLE77? TABLE77 { get; set; }
    public string? SCESSICOI { get; set; }
    public string? SCHANG_ACC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SDOCNUMBE { get; set; }
    public string? SIND_REVER { get; set; }
    public decimal? NINT_MORA { get; set; }
    public string? SINTERMEI { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE95? TABLE95 { get; set; }
    public string? SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE182? TABLE182 { get; set; }
    public DateTime? DPOSTED { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long? NRECEIPT_FA { get; set; }
    public DateTime? DSTATDATE { get; set; }
    public string? SSTATISI { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public int NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.TABLE6? TABLE6 { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public string? SINDASSOCPRO { get; set; }
    public decimal? NPAYSOONDISC { get; set; }
    public string? SIND_ASIS { get; set; }
    public string? SIND_COMI { get; set; }
    public long NBULLETINS { get; set; }
    public int? NCASHNUM { get; set; }
    public int? NPAYREJECT { get; set; }
    public long NCOLLECTOR { get; set; }

    [ForeignKey("NCOLLECTOR")]
    public Insudb.COLLECTOR? COLLECTOR { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SBILLTYPE { get; set; }
    public string? SIND_SOAP { get; set; }
    public string? SINDCHEQUE { get; set; }
    public long? NID { get; set; }
    public long? NRELRECEIPT { get; set; }
    public string? SPROCESS_IND { get; set; }
    public string? SSTIPENDS { get; set; }
    public int? NPAY_SOURCE { get; set; }
    public string? STYPREVERSE { get; set; }
    public decimal? NAMOUNT_LOC { get; set; }
    public int? NCOD_AGREE { get; set; }
    public long? NCONTRAT { get; set; }
    public DateTime? DCTB_DATE { get; set; }
    public string? SPOSTEDSEQUENCE { get; set; }
    public long? NCOLLECTOR_ASSIG { get; set; }
    public long? NBORDEREAUX_ADV { get; set; }
    public long? NBILLNUM_OLD { get; set; }
}
