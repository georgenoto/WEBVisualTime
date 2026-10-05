#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TYPE_AMEND
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NPRODUCT { get; set; }
    public int NTYPE_AMEND { get; set; }

    [ForeignKey("NTYPE_AMEND")]
    public Insudb.TABLE6059? TABLE6059 { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SIND_ORDER_SERV { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int NTYPEISSUE { get; set; }

    [ForeignKey("NTYPEISSUE")]
    public Insudb.TABLE5569? TABLE5569 { get; set; }
    public int NLEVEL { get; set; }
    public string? SRETARIF { get; set; }
    public string? SDESCRIPT { get; set; }
    public int NTYPE_EV_ENDOR { get; set; }

    [ForeignKey("NTYPE_EV_ENDOR")]
    public Insudb.TABLE9232? TABLE9232 { get; set; }
    public string? SRESOLUTION { get; set; }
    public string? SGOVAPRNAME { get; set; }
    public DateTime? DRESDATE { get; set; }
    public string? SCONDSVS { get; set; }
    public int? NTYPEA_AMEND { get; set; }
    public string SSHOWSTATUS { get; set; }
}
