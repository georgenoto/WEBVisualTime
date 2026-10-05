#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLORDER_HIS
{
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.TABLE692? TABLE692 { get; set; }
    public long NORDER_NUM { get; set; }

    [ForeignKey("NORDER_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNORDER_NUM { get; set; }
    public int NMOVEMENT { get; set; }
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int NSTATUS_ORDER { get; set; }

    [ForeignKey("NSTATUS_ORDER")]
    public Insudb.TABLE9241? TABLE9241 { get; set; }
    public int NATTENTCHANNEL { get; set; }

    [ForeignKey("NATTENTCHANNEL")]
    public Insudb.TABLE9237? TABLE9237 { get; set; }
    public int NTYPEDOC_PAY { get; set; }

    [ForeignKey("NTYPEDOC_PAY")]
    public Insudb.TABLE9242? TABLE9242 { get; set; }
    public int NCURREN_DOC { get; set; }

    [ForeignKey("NCURREN_DOC")]
    public Insudb.TABLE11? TABLE11NCURREN_DOC { get; set; }
    public int NCURREN_ORDER { get; set; }

    [ForeignKey("NCURREN_ORDER")]
    public Insudb.TABLE11? TABLE11NCURREN_ORDER { get; set; }
    public int? NPROVIDER { get; set; }
    public string? STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public string? SIND_REV { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int? DPOSTED { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NMOVEMENT_TYPE { get; set; }
    public string? SCARECLASS { get; set; }
    public int NTRANSAC { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public string? SPROLTREATMENT { get; set; }
    public int? NPHYSICIAN { get; set; }
    public int? NMEDICALINSTITUTE { get; set; }
    public int? NCLAIMANTTYPE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NORDER_NUM_ORIG { get; set; }
    public long? NORDER_NUM_GEN { get; set; }
}
