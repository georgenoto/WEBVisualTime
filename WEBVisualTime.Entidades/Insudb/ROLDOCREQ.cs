#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ROLDOCREQ
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CLIALLOPRO? CLIALLOPRONBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CLIALLOPRO? CLIALLOPRONPRODUCT { get; set; }
    public string SPOLITYPE { get; set; }

    [ForeignKey("SPOLITYPE")]
    public Insudb.CLIALLOPRO? CLIALLOPROSPOLITYPE { get; set; }
    public string SCOMPON { get; set; }

    [ForeignKey("SCOMPON")]
    public Insudb.CLIALLOPRO? CLIALLOPROSCOMPON { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.CLIALLOPRO? CLIALLOPRONROLE { get; set; }
    public int NCLASSTYPDOC { get; set; }

    [ForeignKey("NCLASSTYPDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNCLASSTYPDOC { get; set; }
    public int NTYPCLIENTDOC { get; set; }

    [ForeignKey("NTYPCLIENTDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNTYPCLIENTDOC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
