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
    public int? NLED_COMPAN { get; set; }

    [ForeignKey("NLED_COMPAN, SACCOUNT, SAUX_ACCOUN")]
    public Insudb.LEDGER_ACC? LEDGER_ACCNLED_COMPAN { get; set; }
    public string? SACCOUNT { get; set; }

    [NotMapped]
    public Insudb.LEDGER_ACC? LEDGER_ACCSACCOUNT
    {
        get => LEDGER_ACCNLED_COMPAN;
        set => LEDGER_ACCNLED_COMPAN = value;
    }
    public string? SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int? NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public int? NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public string? SAUX_ACCOUN { get; set; }

    [NotMapped]
    public Insudb.LEDGER_ACC? LEDGER_ACCSAUX_ACCOUN
    {
        get => LEDGER_ACCNLED_COMPAN;
        set => LEDGER_ACCNLED_COMPAN = value;
    }
    public int? NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long? NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long? NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int? NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
}
