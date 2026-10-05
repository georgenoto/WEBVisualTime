#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SCHEMA_FOLDER
{
    public string SSCHE_CODE { get; set; }
    public int NFOLDER { get; set; }
    public int? NINQLEVEL { get; set; }
    public string? SPERMITTED { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
