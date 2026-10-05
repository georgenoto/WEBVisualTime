#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COLLECTOR
{
    public long NCOLLECTOR { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NCOLLECTORTYPE { get; set; }

    [ForeignKey("NCOLLECTORTYPE")]
    public Insudb.TABLE5551? TABLE5551 { get; set; }
    public DateTime? DINPUTDATE { get; set; }
    public int NCONTYPE { get; set; }

    [ForeignKey("NCONTYPE")]
    public Insudb.TABLE5557? TABLE5557 { get; set; }
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int NCODE { get; set; }

    [ForeignKey("NCODE")]
    public Insudb.TAB_COLLECTCOMM? TAB_COLLECTCOMM { get; set; }
    public int NLEGAL_SCH { get; set; }

    [ForeignKey("NLEGAL_SCH")]
    public Insudb.TABLE5501? TABLE5501 { get; set; }
    public int NINT_STATUS { get; set; }
    public DateTime DSTATUSDATE { get; set; }
    public int? NOFFICE { get; set; }
    public int? NSUPERVIS { get; set; }
}
