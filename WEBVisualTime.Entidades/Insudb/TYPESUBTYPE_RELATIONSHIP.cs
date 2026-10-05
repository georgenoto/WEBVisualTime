#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TYPESUBTYPE_RELATIONSHIP
{
    public string STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public string SCARECLASS { get; set; }

    [ForeignKey("SCARECLASS")]
    public Insudb.TABLE8605? TABLE8605 { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
