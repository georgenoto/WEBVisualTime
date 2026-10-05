#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CURR_ACC
{
    public int NTYP_ACCO { get; set; }

    [ForeignKey("NTYP_ACCO")]
    public Insudb.TABLE400? TABLE400 { get; set; }
    public string STYPE_ACC { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NCURRENCY { get; set; }
    public decimal? NBALANCE { get; set; }
    public decimal? NCREDIT { get; set; }
    public decimal? NDEBIT { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NLED_COMPAN { get; set; }

    [ForeignKey("NLED_COMPAN")]
    public Insudb.LEDGER_ACC? LEDGER_ACCNLED_COMPAN { get; set; }
    public string? SACCOUNT { get; set; }

    [ForeignKey("SACCOUNT")]
    public Insudb.LEDGER_ACC? LEDGER_ACCSACCOUNT { get; set; }
    public string? SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public string? SAUX_ACCOUN { get; set; }

    [ForeignKey("SAUX_ACCOUN")]
    public Insudb.LEDGER_ACC? LEDGER_ACCSAUX_ACCOUN { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
}
