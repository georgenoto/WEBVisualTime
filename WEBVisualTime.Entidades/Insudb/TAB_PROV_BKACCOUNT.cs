#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_PROV_BKACCOUNT
{
    public int NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public string SACCOUNT { get; set; }
    public int NTYP_ACC { get; set; }

    [ForeignKey("NTYP_ACC")]
    public Insudb.TABLE190? TABLE190 { get; set; }
    public string SSTATREGT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SDEPOSIT { get; set; }
    public string? SCLIENTR { get; set; }

    [ForeignKey("SCLIENTR")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int? NCURRENCY { get; set; }
}
