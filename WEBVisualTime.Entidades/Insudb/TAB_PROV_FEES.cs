#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_FEES
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER, NZONE")]
    public Insudb.TAB_PROV_ZONE? TAB_PROV_ZONENPROVIDER { get; set; }
    public int NZONE { get; set; }

    [NotMapped]
    public Insudb.TAB_PROV_ZONE? TAB_PROV_ZONENZONE
    {
        get => TAB_PROV_ZONENPROVIDER;
        set => TAB_PROV_ZONENPROVIDER = value;
    }
    public string STYPEBENEFIT { get; set; }

    [ForeignKey("STYPEBENEFIT")]
    public Insudb.TABLE8600? TABLE8600 { get; set; }
    public string SBENEFITCLAS { get; set; }

    [ForeignKey("SBENEFITCLAS")]
    public Insudb.TABLE8601? TABLE8601 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal NDISC_FEE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
