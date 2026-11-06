#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COVER_QUOTA
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
    public int NMODULEC { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public int NCOVER { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NTAXIVA { get; set; }
    public decimal? NTAX { get; set; }
    public decimal? NPREMIUM { get; set; }
    public long? NINSUCOUNT { get; set; }
    public long? NINSURED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public long? NCERTIF { get; set; }
}
