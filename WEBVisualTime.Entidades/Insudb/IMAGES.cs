#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class IMAGES
{
    public long NIMAGENUM { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NCONSEC { get; set; }
    public string? SDESCRIPT { get; set; }
    public byte[]? IIMAGE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NRECTYPE { get; set; }
    public int NUSERCODE { get; set; }
}
