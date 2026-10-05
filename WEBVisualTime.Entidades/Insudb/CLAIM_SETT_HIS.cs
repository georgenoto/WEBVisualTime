#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CLAIM_SETT_HIS
{
    public long NSETTLEMENT_NUM { get; set; }
    public int NTRANSAC { get; set; }
    public DateTime DOPERDATE { get; set; }
    public int NPAYMENT_METHOD { get; set; }

    [ForeignKey("NPAYMENT_METHOD")]
    public Insudb.TABLE9252? TABLE9252 { get; set; }
    public int NPAYEE { get; set; }

    [ForeignKey("NPAYEE")]
    public Insudb.TABLE9251? TABLE9251 { get; set; }
    public int NSETTLEMENT_STAT { get; set; }

    [ForeignKey("NSETTLEMENT_STAT")]
    public Insudb.TABLE9250? TABLE9250 { get; set; }
    public int NSETTLEMENT_CONC { get; set; }

    [ForeignKey("NSETTLEMENT_CONC")]
    public Insudb.TABLE9249? TABLE9249 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SREMARKS { get; set; }
    public int NMOVEMENT_TYPE { get; set; }

    [ForeignKey("NMOVEMENT_TYPE")]
    public Insudb.TABLE9266? TABLE9266 { get; set; }
    public int NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE9274? TABLE9274 { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public long? NREQUEST_NU { get; set; }
}
