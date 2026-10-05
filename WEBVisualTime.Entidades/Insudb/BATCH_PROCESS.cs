#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BATCH_PROCESS
{
    public int NBATCH { get; set; }
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public string? SPROC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSTATREGT { get; set; }
}
