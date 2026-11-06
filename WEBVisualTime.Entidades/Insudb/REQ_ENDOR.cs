#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class REQ_ENDOR
{
    public long NREQENDOR { get; set; }
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF
    {
        get => CERTIFICATSCERTYPE;
        set => CERTIFICATSCERTYPE = value;
    }
    public DateTime DREQSTARTENDOR { get; set; }
    public int NTYPEENDOR { get; set; }

    [ForeignKey("NTYPEENDOR")]
    public Insudb.TABLE6059? TABLE6059 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERSNUSERCODE { get; set; }
    public long NUNDERWRITINGCASEID { get; set; }
    public long? NINTERMED { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public int NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE5555? TABLE5555 { get; set; }
    public string? SCERTYPEENDOR { get; set; }
    public long? NPOLICYENDOR { get; set; }
    public string? SOBS { get; set; }
    public string? SREASON_REJECT { get; set; }
    public int? NUSERCODE_REJECT { get; set; }

    [ForeignKey("NUSERCODE_REJECT")]
    public Insudb.USERS? USERSNUSERCODE_REJECT { get; set; }
    public DateTime? DREJECT { get; set; }
    public long? NID_SECUENCIA { get; set; }
    public int NUSERCODE_REQ { get; set; }

    [ForeignKey("NUSERCODE_REQ")]
    public Insudb.USERS? USERSNUSERCODE_REQ { get; set; }
}
