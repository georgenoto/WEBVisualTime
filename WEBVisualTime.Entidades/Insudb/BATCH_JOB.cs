#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BATCH_JOB
{
    public string SKEY { get; set; }
    public int NBATCH { get; set; }

    [ForeignKey("NBATCH")]
    public Insudb.BATCH_PROCESS? BATCH_PROCESS { get; set; }
    public DateTime? DSTART { get; set; }
    public DateTime? DEND { get; set; }
    public int? NSTATUS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public string? SCOMMAND { get; set; }
    public DateTime? DSUBMIT { get; set; }
    public long? NORAJOB { get; set; }
    public int? NUSERSUBMIT { get; set; }
    public int? NSHEET { get; set; }
    public string? SKEY_FATHER { get; set; }
    public string? SOUTPUTFILE { get; set; }
    public string? SFILE { get; set; }
    public string? SVERIFIED_PLA { get; set; }
}
