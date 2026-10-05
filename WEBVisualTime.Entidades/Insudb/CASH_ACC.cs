#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CASH_ACC
{
    public int NACC_CASH { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NLED_COMPAN { get; set; }

    [ForeignKey("NLED_COMPAN")]
    public Insudb.LEDGER_ACC? LEDGER_ACCNLED_COMPAN { get; set; }
    public string? SACCOUNT { get; set; }

    [ForeignKey("SACCOUNT")]
    public Insudb.LEDGER_ACC? LEDGER_ACCSACCOUNT { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string? SAUX_ACCOUN { get; set; }

    [ForeignKey("SAUX_ACCOUN")]
    public Insudb.LEDGER_ACC? LEDGER_ACCSAUX_ACCOUN { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NAVAILABLE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SSTATREGT { get; set; }
    public int NCASHNUM { get; set; }
    public decimal? NMIN_AMOUNT { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public int? NTYPECASH { get; set; }
}
