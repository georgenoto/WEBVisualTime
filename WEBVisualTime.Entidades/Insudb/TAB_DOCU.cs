#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_DOCU
{
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.TABLE10? TABLE10 { get; set; }
    public int NDOC_CODE { get; set; }
    public int NPRODUCT { get; set; }
    public int NCOVER { get; set; }
    public int NMODULEC { get; set; }
    public int NCAUSECOD { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public string? SDESCRIPT { get; set; }
    public string? SSHORT_DES { get; set; }
    public string? SSTATREGT { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCLAIMPAY { get; set; }
    public int? NDAYS_PRESC { get; set; }
    public string? STEXT { get; set; }
    public string? SREQUIERED { get; set; }
    public int? NPERSON_TYP { get; set; }
    public int NDOC_TYPE { get; set; }

    [ForeignKey("NDOC_TYPE")]
    public Insudb.TABLE9217? TABLE9217 { get; set; }
}
