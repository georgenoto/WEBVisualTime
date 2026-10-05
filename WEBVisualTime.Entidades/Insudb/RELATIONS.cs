#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class RELATIONS
{
    public string SCLIENTR { get; set; }

    [ForeignKey("SCLIENTR")]
    public Insudb.CLIENT? CLIENTSCLIENTR { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENTSCLIENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NRELASHIP { get; set; }

    [ForeignKey("NRELASHIP")]
    public Insudb.TABLE15? TABLE15 { get; set; }
    public int NUSERCODE { get; set; }
}
