#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_TMP
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY")]
    public Insudb.POLICY? POLICYSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNBRANCH
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNPRODUCT
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNPOLICY
    {
        get => POLICYSCERTYPE;
        set => POLICYSCERTYPE = value;
    }
    public int NGROUP { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public int NID { get; set; }
    public string? STYPEAGE { get; set; }
    public DateTime? DBIRTHDATE { get; set; }
    public int? NINITAGE { get; set; }
    public int? NENDAGE { get; set; }
    public long? NINSURED { get; set; }
    public decimal? NRENTAMOUNT { get; set; }
    public int? NCURRENCY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SVIP { get; set; }
    public string? SSEXCLIEN { get; set; }
}
