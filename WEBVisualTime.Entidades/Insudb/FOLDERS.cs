#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class FOLDERS
{
    public int NFOLDER { get; set; }
    public string SFOLDERNAME { get; set; }
    public string SROOTNAME { get; set; }
    public int? NIMAGE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SCLASS { get; set; }
    public string? SFOLDERKEY { get; set; }
    public int NFOLDERKEY { get; set; }

    [ForeignKey("NFOLDERKEY")]
    public Insudb.PROPERTYLIBRARY? PROPERTYLIBRARY { get; set; }
    public string SORIGI { get; set; }
}
