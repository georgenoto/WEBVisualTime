#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class WIN_ACTIONS
{
    public string SCODISPL { get; set; }

    [ForeignKey("SCODISPL")]
    public Insudb.WINDOWS? WINDOWS { get; set; }
    public int? NACTION { get; set; }

    [ForeignKey("NACTION")]
    public Insudb.ACTIONS? ACTIONS { get; set; }
    public int NSEQUENCE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
