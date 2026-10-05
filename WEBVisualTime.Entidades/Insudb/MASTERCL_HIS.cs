#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASTERCL_HIS
{
    public long NMASTERORDER { get; set; }
    public int NMOVEMENT { get; set; }
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int NSTATORDER_MAST { get; set; }

    [ForeignKey("NSTATORDER_MAST")]
    public Insudb.TABLE9264? TABLE9264 { get; set; }
    public int NATTENTCHANNEL { get; set; }

    [ForeignKey("NATTENTCHANNEL")]
    public Insudb.TABLE9237? TABLE9237 { get; set; }
    public int NTYPEDOC_PAY { get; set; }

    [ForeignKey("NTYPEDOC_PAY")]
    public Insudb.TABLE9242? TABLE9242 { get; set; }
    public int? NCURREN_DOC { get; set; }
    public int? NCURREN_ORDER { get; set; }
    public int? NPROVIDER { get; set; }
    public string? STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public string? SCARECLASS { get; set; }
    public string? SIND_REV { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public int NMOVEMENT_TYPE { get; set; }

    [ForeignKey("NMOVEMENT_TYPE")]
    public Insudb.TABLE9243? TABLE9243 { get; set; }
    public int NTRANSAC { get; set; }
    public string? SPREAUTHORIZATION { get; set; }
    public int NCLAIMANTTYPE { get; set; }

    [ForeignKey("NCLAIMANTTYPE")]
    public Insudb.TABLE9212? TABLE9212 { get; set; }
    public long? NCLAIM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NMASTERORDER_NUM_ORIG { get; set; }
    public long? NMASTERORDER_NUM_GEN { get; set; }
}
