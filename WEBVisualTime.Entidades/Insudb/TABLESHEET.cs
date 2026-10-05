#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLESHEET
{
    public int NSHEET { get; set; }
    public string STABLE { get; set; }
    public string SALIAS { get; set; }
    public int NORDER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
