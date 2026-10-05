#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_AU_VEH
{
    public string SVEHCODE { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NNATIONAL { get; set; }
    public int? NVEHBRAND { get; set; }
    public string? SSTATREGT { get; set; }
    public string? SVEHMODEL { get; set; }
    public int NVEHTYPE { get; set; }

    [ForeignKey("NVEHTYPE")]
    public Insudb.TABLE226? TABLE226 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NVEHPLACE { get; set; }
    public int? NVEHPMA { get; set; }
    public int? NSOAP_VEHTYPE { get; set; }
    public string? SAACHCODE { get; set; }
    public int? NGROUPVEH { get; set; }
}
