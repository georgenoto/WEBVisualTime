#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class ASCII_I_DET
{
    public string SASCII_NAME { get; set; }

    [ForeignKey("SASCII_NAME")]
    public Insudb.ASCII_I_HEAD? ASCII_I_HEAD { get; set; }
    public int NID { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public string SCLIENAME { get; set; }
    public long NREQUEST_NEW { get; set; }
    public decimal NAMOUNT { get; set; }
    public string SDESCRIPT { get; set; }
    public string SBANKACCOUNT { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public int NOFF_DEST_ID { get; set; }

    [ForeignKey("NOFF_DEST_ID")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NPAY_ID { get; set; }

    [ForeignKey("NPAY_ID")]
    public Insudb.TABLE9229? TABLE9229 { get; set; }
    public DateTime DDATE_PAY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
