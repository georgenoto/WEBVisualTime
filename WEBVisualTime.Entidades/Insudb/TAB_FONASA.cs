#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_FONASA
{
    public int NYEAR { get; set; }
    public string SSERVICE { get; set; }
    public string SSUBSERVICE { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NBRANCH { get; set; }
    public int? NPRODUCT { get; set; }
}
