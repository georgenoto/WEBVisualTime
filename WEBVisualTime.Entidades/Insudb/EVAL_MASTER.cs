#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class EVAL_MASTER
{
    public long NEVAL { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int? NBRANCH { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public int? NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATNBRANCH;
        set => CERTIFICATNBRANCH = value;
    }
    public long? NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATNBRANCH;
        set => CERTIFICATNBRANCH = value;
    }
    public DateTime DSTARTDATE { get; set; }
    public long? NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATNBRANCH;
        set => CERTIFICATNBRANCH = value;
    }
    public DateTime DEXPIRDAT { get; set; }
    public int NSTATUS_EVAL { get; set; }

    [ForeignKey("NSTATUS_EVAL")]
    public Insudb.TABLE5572? TABLE5572 { get; set; }
    public decimal? NCAPITAL { get; set; }
    public long? NNOTEREST { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NCUMUL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCERTYPE { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE
    {
        get => CERTIFICATNBRANCH;
        set => CERTIFICATNBRANCH = value;
    }
}
