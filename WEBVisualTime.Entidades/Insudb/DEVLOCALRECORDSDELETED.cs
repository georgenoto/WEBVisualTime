#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DEVLOCALRECORDSDELETED
{
    public int LOCALRECDELID { get; set; }
    public string NAME { get; set; }
    public DateTime DELDATE { get; set; }
    public string PKEY { get; set; }
    public int LOCALTABLEID { get; set; }
}
