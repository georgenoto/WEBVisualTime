#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_CL_OPE
{
    public int NOPER_TYPE { get; set; }

    [ForeignKey("NOPER_TYPE")]
    public Insudb.TABLE140? TABLE140NOPER_TYPE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NGEN_OPERA { get; set; }

    [ForeignKey("NGEN_OPERA")]
    public Insudb.TABLE140? TABLE140NGEN_OPERA { get; set; }
    public int? NIND_REV { get; set; }
    public int? NPAY_IND { get; set; }

    [ForeignKey("NPAY_IND")]
    public Insudb.TABLE294? TABLE294NPAY_IND { get; set; }
    public int? NREC_ESP_IN { get; set; }

    [ForeignKey("NREC_ESP_IN")]
    public Insudb.TABLE294? TABLE294NREC_ESP_IN { get; set; }
    public int? NRECOVER_IN { get; set; }

    [ForeignKey("NRECOVER_IN")]
    public Insudb.TABLE294? TABLE294NRECOVER_IN { get; set; }
    public int? NRESERVE_IN { get; set; }

    [ForeignKey("NRESERVE_IN")]
    public Insudb.TABLE294? TABLE294NRESERVE_IN { get; set; }
    public int NUSERCODE { get; set; }
}
