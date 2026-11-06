#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DISCO_EXPR
{
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public int NDISEXPRC { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int? NBRANCH_REI { get; set; }

    [ForeignKey("NBRANCH_REI")]
    public Insudb.TABLE5000? TABLE5000 { get; set; }
    public int? NBILL_ITEM { get; set; }
    public string? SCHANALLO { get; set; }
    public int? NBRANCH_EST { get; set; }

    [ForeignKey("NBRANCH_EST")]
    public Insudb.TABLE71? TABLE71 { get; set; }
    public string? SCOMMISSI_I { get; set; }
    public int? NBRANCH_LED { get; set; }

    [ForeignKey("NBRANCH_LED")]
    public Insudb.TABLE75? TABLE75 { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SDEFAULTI { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SDEVOALLO { get; set; }
    public decimal? NDISEXMAX { get; set; }
    public decimal? NDISEXMIN { get; set; }
    public decimal? NDISEXPRA { get; set; }
    public string? SEDPERAPL { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NORDER_APL { get; set; }
    public string? SPRORATE { get; set; }
    public string? SREQUIRE { get; set; }
    public string? SROUTINE { get; set; }
    public string? SSHORT_DES { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NAMELEVEL { get; set; }
    public string? SDISEXPRI { get; set; }

    [ForeignKey("SDISEXPRI")]
    public Insudb.TABLE30? TABLE30 { get; set; }
    public string? SSTATREGT { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SDEFPOL { get; set; }
    public string? STYPMAR { get; set; }
    public string? SIVA { get; set; }
    public long? NAPLY { get; set; }
    public decimal? NRATE { get; set; }
    public decimal? NDISEXSUBPER { get; set; }
    public decimal? NDISEXADDPER { get; set; }
    public string? SIND_STIPENDS { get; set; }
    public int? NDINSUR_TYPE { get; set; }
}
