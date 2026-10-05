#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PAY_ORD_CONCEPTS
{
    public int NCOMPANY { get; set; }
    public int NCONCEPT { get; set; }

    [ForeignKey("NCONCEPT")]
    public Insudb.TABLE293? TABLE293 { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
