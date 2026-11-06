#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class USER_OFFICE
{
    public int NUSER { get; set; }
    public int NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public int? NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DCOMPDATE { get; set; }
}
