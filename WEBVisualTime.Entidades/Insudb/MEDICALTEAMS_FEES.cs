#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MEDICALTEAMS_FEES
{
    public int NOFFICE { get; set; }
    public int NDOCTORROL { get; set; }
    public int NORD_PROCEDURE { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public decimal NPERCENTAGE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
