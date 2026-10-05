#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BANK_AGREE
{
    public string STYPE_BANKAGREE { get; set; }
    public long NBANK { get; set; }

    [ForeignKey("NBANK")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public int NACCOUNT { get; set; }

    [ForeignKey("NACCOUNT")]
    public Insudb.BANK_ACC? BANK_ACC { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int? NNUMDIGIT { get; set; }
    public string? SFORMAT { get; set; }
}
