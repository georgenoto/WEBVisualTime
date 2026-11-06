#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ROLDOCREQ
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH, NPRODUCT, SPOLITYPE, SCOMPON, NROLE")]
    public Insudb.CLIALLOPRO? CLIALLOPRONBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CLIALLOPRO? CLIALLOPRONPRODUCT
    {
        get => CLIALLOPRONBRANCH;
        set => CLIALLOPRONBRANCH = value;
    }
    public string SPOLITYPE { get; set; }

    [NotMapped]
    public Insudb.CLIALLOPRO? CLIALLOPROSPOLITYPE
    {
        get => CLIALLOPRONBRANCH;
        set => CLIALLOPRONBRANCH = value;
    }
    public string SCOMPON { get; set; }

    [NotMapped]
    public Insudb.CLIALLOPRO? CLIALLOPROSCOMPON
    {
        get => CLIALLOPRONBRANCH;
        set => CLIALLOPRONBRANCH = value;
    }
    public int NROLE { get; set; }

    [NotMapped]
    public Insudb.CLIALLOPRO? CLIALLOPRONROLE
    {
        get => CLIALLOPRONBRANCH;
        set => CLIALLOPRONBRANCH = value;
    }
    public int NCLASSTYPDOC { get; set; }

    [ForeignKey("NTYPCLIENTDOC, NCLASSTYPDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNCLASSTYPDOC { get; set; }
    public int NTYPCLIENTDOC { get; set; }

    [NotMapped]
    public Insudb.FORMATVALUES? FORMATVALUESNTYPCLIENTDOC
    {
        get => FORMATVALUESNCLASSTYPDOC;
        set => FORMATVALUESNCLASSTYPDOC = value;
    }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
