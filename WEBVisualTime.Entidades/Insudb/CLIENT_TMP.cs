#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIENT_TMP
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
