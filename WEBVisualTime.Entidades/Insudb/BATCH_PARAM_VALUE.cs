#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BATCH_PARAM_VALUE
{
    public string SKEY { get; set; }

    [ForeignKey("SKEY")]
    public Insudb.BATCH_JOB? BATCH_JOB { get; set; }
    public int NAREA { get; set; }

    [ForeignKey("NAREA")]
    public Insudb.BATCH_PARAM? BATCH_PARAMNAREA { get; set; }
    public int NSEQ { get; set; }

    [ForeignKey("NSEQ")]
    public Insudb.BATCH_PARAM? BATCH_PARAMNSEQ { get; set; }
    public int NBATCH { get; set; }

    [ForeignKey("NBATCH")]
    public Insudb.BATCH_PARAM? BATCH_PARAMNBATCH { get; set; }
    public string? SVALUE { get; set; }
    public int? NDATATYPE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
}
