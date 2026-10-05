#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TCOMMISS
{
    public string? SKEY { get; set; }
    public long? NINTERMED { get; set; }
    public decimal? NCOMMISSION { get; set; }
    public decimal? NSHARE { get; set; }
    public int? NCURRENCY { get; set; }
    public decimal? NCOM_AFEC { get; set; }
    public decimal? NCOM_EXEN { get; set; }
    public decimal? NPERCENT { get; set; }
}
