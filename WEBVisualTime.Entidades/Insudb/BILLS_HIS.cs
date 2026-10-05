#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class BILLS_HIS
{
    public string SBILLTYPE { get; set; }
    public long NBILLNUM { get; set; }
    public DateTime DSTATDATE { get; set; }
    public int NTRANSAC { get; set; }
    public int NBILLMOVCODE { get; set; }
    public string STEXT { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public long? NBILLNUM_OLD { get; set; }
    public DateTime? DSTATDATE_OLD { get; set; }
    public int? NUSER { get; set; }
    public int? NUSER_OLD { get; set; }
    public long? NIDTRANSACTION { get; set; }
    public long? NIDTRANSACTION_OLD { get; set; }
    public string? SBILLNUMSFE { get; set; }
    public string? SBILLNUMSFE_OLD { get; set; }
    public string? SNOTEDESCRIPTS { get; set; }
}
