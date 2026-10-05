#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SEQFOLDER
{
    public int NQUERYTYPE { get; set; }
    public int NPARENT { get; set; }
    public int NFOLDER { get; set; }

    [ForeignKey("NFOLDER")]
    public Insudb.FOLDERS? FOLDERS { get; set; }
    public int NSEQUENCE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
