#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class HOLLIDAYS
{
    public long NMONTH { get; set; }

    [ForeignKey("NMONTH")]
    public Insudb.TABLE7013? TABLE7013 { get; set; }
    public int NDAY { get; set; }
    public string SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NCOUNTRY { get; set; }
    public int? NYEAR { get; set; }
}
