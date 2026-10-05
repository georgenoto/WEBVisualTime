#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PRECLAIM
{
    public long NIDPRECLAIM { get; set; }
    public string SCERTYPE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long? NCERTIF { get; set; }
    public DateTime DOCCURDATE { get; set; }
    public DateTime DREPDATE { get; set; }
    public string? SADDRESS { get; set; }
    public decimal NDAMAGES { get; set; }
    public int? NCURRENCY { get; set; }
    public int NIDSTATPRECLAIM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int? NPRECLAIM { get; set; }
    public string? SNAMECLIENT { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SCLIENT_AFFECT { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NATTENTCHANNEL { get; set; }

    [ForeignKey("NATTENTCHANNEL")]
    public Insudb.TABLE9237? TABLE9237 { get; set; }
    public string? SCLINUMDOCU { get; set; }
    public int? NCOUNTRY { get; set; }
    public string? SLOCALOCCUR { get; set; }
    public string? SACCIDENT { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public int NORDERTYPE { get; set; }

    [ForeignKey("NORDERTYPE")]
    public Insudb.TABLE9238? TABLE9238 { get; set; }
    public DateTime? DSTATUS { get; set; }
    public DateTime? DREJECTION { get; set; }
    public DateTime? DREJECTNOTICE { get; set; }
    public int? NREJECTUSER { get; set; }
    public long NMASTERORDER { get; set; }

    [ForeignKey("NMASTERORDER")]
    public Insudb.MASTERCL_ORDER? MASTERCL_ORDER { get; set; }
    public int? NPROVIDER { get; set; }
    public int? NPHYSICIAN { get; set; }
    public int? NMEDICALINSTITUTE { get; set; }
    public string? SCALLCENTER { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public int NCLA_LI_TYP { get; set; }

    [ForeignKey("NCLA_LI_TYP")]
    public Insudb.TABLE210? TABLE210 { get; set; }
    public int? NCAUSEREOPENCL { get; set; }
    public int? NTYPE_COMMPAY { get; set; }
    public DateTime? DREOPENCL { get; set; }
    public int? NREOPENUSER { get; set; }
    public DateTime? DCONFREJECTION { get; set; }
    public DateTime? DCONFREJECTNOTICE { get; set; }
    public int? NCONFREJECTUSER { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNULLCODE { get; set; }
    public string? SHISTORICAL_CLAIM { get; set; }
}
