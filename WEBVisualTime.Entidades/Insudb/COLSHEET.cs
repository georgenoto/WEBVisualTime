#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COLSHEET
{
    public int NID { get; set; }
    public int NIDREC { get; set; }
    public string SCOLUMNNAME { get; set; }
    public int? NORDER { get; set; }
    public string? SSELECTED { get; set; }
    public string? SREQUIRE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SVALUE { get; set; }
}
