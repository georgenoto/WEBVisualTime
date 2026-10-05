#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TARIF_COLUMN
{
    public int NID_COLUMN { get; set; }
    public string STABLE { get; set; }
    public string SCOLUMN { get; set; }
    public string SNAME_COL { get; set; }
    public int? NDATA_TYPE { get; set; }
    public int? NSIZE { get; set; }
    public int? NDECIMAL { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? STABLEFK { get; set; }
}
