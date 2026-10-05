#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMIS_HIS
{
    public long NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public string STYP_COMISS { get; set; }

    [ForeignKey("STYP_COMISS")]
    public Insudb.TABLE7504? TABLE7504 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NCOMTAB { get; set; }
}
