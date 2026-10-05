#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLE9218
{
    public int NIDSTATPRECLAIM { get; set; }

    [ForeignKey("NIDSTATPRECLAIM")]
    public Insudb.TABLE9218? TABLE9218Parent { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SDESCRIPT { get; set; }
    public string SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
}
