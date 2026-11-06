#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FINANC_PRE
{
    public int? NBRANCH { get; set; }
    public decimal? NCOMMISSION { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long NCONTRAT { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime? DSTARTDATE { get; set; }
    public decimal? NEXCHANGE { get; set; }
    public DateTime? DEXPIRDAT { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public long? NPOLICY { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long NRECEIPT { get; set; }
    public string? SSTAT_FINPR { get; set; }
    public string SSTATREGT { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int? NPRODUCT { get; set; }
    public int? NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public string? SEXTRECEIPT { get; set; }
}
