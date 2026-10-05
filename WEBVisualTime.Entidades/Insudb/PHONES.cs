#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PHONES
{
    public int NRECOWNER { get; set; }
    public string SKEYADDRESS { get; set; }
    public int NKEYPHONES { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public long NBESTTIMETOCALL { get; set; }

    [ForeignKey("NBESTTIMETOCALL")]
    public Insudb.TABLE8060? TABLE8060 { get; set; }
    public int? NAREA_CODE { get; set; }
    public string? SPHONE { get; set; }
    public int? NORDER { get; set; }
    public int? NEXTENS1 { get; set; }
    public int? NEXTENS2 { get; set; }
    public int NPHONE_TYPE { get; set; }

    [ForeignKey("NPHONE_TYPE")]
    public Insudb.TABLE564? TABLE564 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NCOUNTRY_CODE { get; set; }
    public string? SASSOCADDR { get; set; }
    public int? NPHONECLAS { get; set; }
}
