#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SITUATION
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
    public int NSITUATION { get; set; }
    public int NCOD_AGREE { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public decimal? NPARTICIP_POLEMP { get; set; }
    public decimal? NPARTICIP_POLCO { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
}
