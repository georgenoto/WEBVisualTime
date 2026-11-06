#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class USER_CASHNUM
{
    public int NCASHNUM { get; set; }
    public string SSTATUS { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSER { get; set; }

    [ForeignKey("NUSER")]
    public Insudb.USERS? USERSNUSER { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERSNUSERCODE { get; set; }
    public int? NCASHSUP { get; set; }

    [ForeignKey("NCASHSUP")]
    public Insudb.USERS? USERSNCASHSUP { get; set; }
    public int? NHEADSUP { get; set; }

    [ForeignKey("NHEADSUP")]
    public Insudb.USERS? USERSNHEADSUP { get; set; }
    public int NOFFICEAGEN { get; set; }
    public int? NTYPECASH { get; set; }
}
