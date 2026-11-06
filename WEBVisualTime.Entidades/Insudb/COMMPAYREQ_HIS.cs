#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMPAYREQ_HIS
{
    public long NID_COMMPAYREQ { get; set; }

    [ForeignKey("NID_COMMPAYREQ")]
    public Insudb.COMMPAYMENTREQUESTS? COMMPAYMENTREQUESTS { get; set; }
    public int NMOVEMENT { get; set; }
    public DateTime? DMOVEMENT_DATE { get; set; }
    public int? NMOVEMENT_TYPE { get; set; }

    [ForeignKey("NMOVEMENT_TYPE")]
    public Insudb.TABLE9276? TABLE9276 { get; set; }
    public int? NSTATUS { get; set; }

    [ForeignKey("NSTATUS")]
    public Insudb.TABLE9275? TABLE9275 { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCLARIFICATIONREQUESTED { get; set; }
    public string? SJUSTIFICATIONREQUESTED { get; set; }
    public int? NUSERCODE_RESPONSIBLE { get; set; }
    public DateTime? DRESULTDATE { get; set; }
    public string? SIND_RESULT { get; set; }
    public string? SIND_ASSUMEIVA { get; set; }
    public int? NCURRENCY_PAY { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NNULLCODE { get; set; }
}
