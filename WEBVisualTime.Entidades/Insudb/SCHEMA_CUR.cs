#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class SCHEMA_CUR
{
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public int NCURRENCY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
