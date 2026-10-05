#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_SYS_EXE
{
    public int NEXE_CODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SEXE_NAME { get; set; }
    public string? SDESCRIPT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SFOLDERNAME { get; set; }
}
