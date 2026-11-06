#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DRAFT_HIST
{
    public decimal? NAMOUNT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public long NTRANSAC { get; set; }
    public int? NCURRENCY { get; set; }
    public int NDRAFT { get; set; }
    public decimal? NDSCTO_PAG { get; set; }
    public decimal? NEXPENSIVE { get; set; }
    public decimal? NINTEREST { get; set; }
    public string? SINTERMEI { get; set; }
    public DateTime? DSTAT_DATE { get; set; }
    public long? NTYPE { get; set; }

    [ForeignKey("NTYPE")]
    public Insudb.TABLE260? TABLE260 { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public long? NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public string? SDOCNUMBE { get; set; }
    public string? SPAY_FORM { get; set; }

    [ForeignKey("SPAY_FORM")]
    public Insudb.TABLE182? TABLE182 { get; set; }
    public string? SCHANGE_ACC { get; set; }
    public string? SAUX_ACCOUN { get; set; }
    public int? NCASHNUM { get; set; }
    public int? NPAYREJECT { get; set; }
    public long? NCOLLECTOR { get; set; }

    [ForeignKey("NCOLLECTOR")]
    public Insudb.COLLECTOR? COLLECTOR { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public DateTime? DPOSTED { get; set; }
    public string? SCESSICOI { get; set; }
    public long? NBILLNUM { get; set; }
    public string? SIND_REVER { get; set; }
}
