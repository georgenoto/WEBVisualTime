#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class T_ERR_MASSIVE
{
    public string SKEY { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
    public long? NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public long? NERROR { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCERTYPE { get; set; }
    public string? SCLIENT { get; set; }
    public long? NSEQ { get; set; }
    public string? STYPE { get; set; }
}
