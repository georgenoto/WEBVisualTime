#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class GROUPVARIABLES
{
    public int NLETT_GROUP { get; set; }

    [ForeignKey("NLETT_GROUP")]
    public Insudb.GROUPPARAMS? GROUPPARAMS { get; set; }
    public string SVARIABLE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? STABLENAME { get; set; }
    public string? SCOLUMNAME { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NTYPVARIABLE { get; set; }
    public string? STABVALUE { get; set; }
    public string? SALIASTABLE { get; set; }
    public string? SALIASCOLUMN { get; set; }
}
