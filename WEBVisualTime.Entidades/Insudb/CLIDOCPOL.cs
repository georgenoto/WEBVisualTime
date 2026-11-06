#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLIDOCPOL
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public int NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public string SCLIENT { get; set; }
    public int NCLASSTYPDOC { get; set; }

    [ForeignKey("NTYPCLIENTDOC, NCLASSTYPDOC")]
    public Insudb.FORMATVALUES? FORMATVALUESNCLASSTYPDOC { get; set; }
    public int NTYPCLIENTDOC { get; set; }

    [NotMapped]
    public Insudb.FORMATVALUES? FORMATVALUESNTYPCLIENTDOC
    {
        get => FORMATVALUESNCLASSTYPDOC;
        set => FORMATVALUESNCLASSTYPDOC = value;
    }
    public DateTime DEFFECDATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime? DRECEP_DATE { get; set; }
    public DateTime? DDATEVIG { get; set; }
    public int NSTAT_DOCREQ { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DLIMIT_DATE { get; set; }
    public long? NID_SECUENCIA { get; set; }
}
