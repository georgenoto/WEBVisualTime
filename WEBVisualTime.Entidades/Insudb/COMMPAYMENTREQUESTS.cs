#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMPAYMENTREQUESTS
{
    public long NID_COMMPAYREQ { get; set; }
    public DateTime? DREGISTRATIONDATE { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string? SCLIENT_HOLDER { get; set; }

    [ForeignKey("SCLIENT_HOLDER")]
    public Insudb.CLIENT? CLIENTSCLIENT_HOLDER { get; set; }
    public string? SCLIENAME_HOLDER { get; set; }
    public string? SCLIENT_INSURED { get; set; }

    [ForeignKey("SCLIENT_INSURED")]
    public Insudb.CLIENT? CLIENTSCLIENT_INSURED { get; set; }
    public string? SCLIENAME_INSURED { get; set; }
    public string? SCLIENT_AFFECT { get; set; }

    [ForeignKey("SCLIENT_AFFECT")]
    public Insudb.CLIENT? CLIENTSCLIENT_AFFECT { get; set; }
    public string? SCLIENAME_AFFECT { get; set; }
    public int? NAGE_AFFECT { get; set; }
    public int? NROLE { get; set; }

    [ForeignKey("NROLE")]
    public Insudb.TABLE12? TABLE12 { get; set; }
    public DateTime? DINSURENTRYDATE { get; set; }
    public DateTime DOCCURDAT { get; set; }
    public long NIDPRECLAIM { get; set; }

    [ForeignKey("NIDPRECLAIM")]
    public Insudb.PRECLAIM? PRECLAIM { get; set; }
    public string? STYPECARE_PRECLAIM { get; set; }

    [ForeignKey("STYPECARE_PRECLAIM")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public long? NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM? CLAIM { get; set; }
    public DateTime? DREJECTEDDATE { get; set; }
    public decimal? NAMOUNTREJECTED_PRECLAIM { get; set; }
    public long? NCURRENCY { get; set; }

    [ForeignKey("NCURRENCY")]
    public Insudb.TABLE11? TABLE11NCURRENCY { get; set; }
    public string? DIAGNOSIS_PRECLAIM { get; set; }
    public string? REASONREJECT_PRECLAIM { get; set; }
    public string? SCLARIFICATIONREQUESTED { get; set; }
    public string? SJUSTIFICATIONREQUESTED { get; set; }
    public int? NUSERCODE_RESPONSIBLE { get; set; }

    [ForeignKey("NUSERCODE_RESPONSIBLE")]
    public Insudb.USERS? USERSNUSERCODE_RESPONSIBLE { get; set; }
    public DateTime? DRESULTDATE { get; set; }
    public string? SIND_RESULT { get; set; }
    public string? SIND_ASSUMEIVA { get; set; }
    public long? NCURRENCY_PAY { get; set; }

    [ForeignKey("NCURRENCY_PAY")]
    public Insudb.TABLE11? TABLE11NCURRENCY_PAY { get; set; }
    public decimal? NAMOUNT_PAY { get; set; }
    public int? NPERCENTPAY { get; set; }
    public string? SOBSERVATIONSRESULT { get; set; }
    public string? SCLIENAME_AUTHORIZER1 { get; set; }
    public string? SPOSITION_AUTHORIZER1 { get; set; }
    public string? SCLIENAME_AUTHORIZER2 { get; set; }
    public string? SPOSITION_AUTHORIZER2 { get; set; }
    public DateTime? DLETTERDATE { get; set; }
    public long? NNUMBERLETTER { get; set; }
    public string? SADDRESSEDTO { get; set; }
    public int NSTATUS { get; set; }

    [ForeignKey("NSTATUS")]
    public Insudb.TABLE9275? TABLE9275 { get; set; }
    public long? NNOTENUM { get; set; }
    public int? NMOVEMENT { get; set; }
    public int? NUSER_AMEND { get; set; }

    [ForeignKey("NUSER_AMEND")]
    public Insudb.USERS? USERSNUSER_AMEND { get; set; }
    public int? NUSER_DERIVEDBY { get; set; }

    [ForeignKey("NUSER_DERIVEDBY")]
    public Insudb.USERS? USERSNUSER_DERIVEDBY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERSNUSERCODE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NNULLCODE { get; set; }
}
