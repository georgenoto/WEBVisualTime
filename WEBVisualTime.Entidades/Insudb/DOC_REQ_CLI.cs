#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DOC_REQ_CLI
{
    public long NEVAL { get; set; }

    [ForeignKey("NEVAL")]
    public Insudb.EVAL_MASTER? EVAL_MASTER { get; set; }
    public long NID { get; set; }
    public int? NTYPEDOC { get; set; }

    [ForeignKey("NTYPEDOC")]
    public Insudb.TABLE32? TABLE32 { get; set; }
    public int NSTATUSDOC { get; set; }

    [ForeignKey("NSTATUSDOC")]
    public Insudb.TABLE275? TABLE275 { get; set; }
    public string? SDESCRIPT { get; set; }
    public DateTime DDOCREQ { get; set; }
    public DateTime? DDOCREC { get; set; }
    public DateTime DDOCDATE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public decimal NCAPITAL { get; set; }
    public long? NNOTENUM { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DDATETO { get; set; }
    public DateTime? DDATEFREE { get; set; }
    public string? SREQUEST { get; set; }
}
