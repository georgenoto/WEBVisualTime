#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BATCH_PARAM
{
    public int NBATCH { get; set; }

    [ForeignKey("NBATCH")]
    public Insudb.BATCH_PROCESS? BATCH_PROCESS { get; set; }
    public int NAREA { get; set; }
    public int NSEQ { get; set; }
    public string? SNAME { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
