#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class AGREEMENT_AL
{
    public int NAGREEMENT { get; set; }
    public string SDESCRIPT { get; set; }
    public DateTime DSTARTDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string SLEVELINT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int? NAGREE_TYPE { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
}
