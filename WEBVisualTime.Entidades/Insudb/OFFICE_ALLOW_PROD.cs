#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class OFFICE_ALLOW_PROD
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NOFFICE_PROD { get; set; }

    [ForeignKey("NOFFICE_PROD")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
}
