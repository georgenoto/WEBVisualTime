#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COVER_QUOTA
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.POLICY? POLICYSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.POLICY? POLICYNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.POLICY? POLICYNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.POLICY? POLICYNPOLICY { get; set; }
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
