#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CHEQUE_MOV
{
    public int NCOMPANY { get; set; }

    [ForeignKey("NCOMPANY")]
    public Insudb.COMPANY? COMPANY { get; set; }
    public long NBANK_CODE { get; set; }

    [ForeignKey("NBANK_CODE")]
    public Insudb.TABLE7? TABLE7NBANK_CODE { get; set; }
    public string SCHEQUENU { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NCHEOPERTYP { get; set; }
    public int NCHEOPER_REASON { get; set; }

    [ForeignKey("NCHEOPER_REASON")]
    public Insudb.TABLE5577? TABLE5577 { get; set; }
    public int NID { get; set; }
    public long NBANK_INTER { get; set; }

    [ForeignKey("NBANK_INTER")]
    public Insudb.TABLE7? TABLE7NBANK_INTER { get; set; }
    public string? SCHEQUEINTER { get; set; }
    public DateTime? DNEW_DATE { get; set; }
    public string? SDEPNUMBER { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public decimal? NFIN_INT { get; set; }
    public long? NNOTENUM { get; set; }
}
