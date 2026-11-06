#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class GROUPS
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
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.POLICY? POLICYNPOLICY
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
    public int NGROUP { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public string? SDESCRIPT { get; set; }
    public decimal? NPARTICIP { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPARTICIP_CO { get; set; }
    public long? NMOVEMENT { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
