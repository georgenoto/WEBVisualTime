#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_MEDBENEFITS
{
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
    public int NID { get; set; }
    public int NMODULEC { get; set; }
    public int NCOVER { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public string SCLIENT { get; set; }
    public int NGROUP_INSU { get; set; }
    public int? NROLE { get; set; }
    public int? NQUANTITY { get; set; }
    public long? NAMOUNT_BENE { get; set; }
    public int? NPERCEN_HOSPITAL { get; set; }
    public int? NPERCEN_AMBULATORY { get; set; }
    public int? NDED_TYPE { get; set; }

    [ForeignKey("NDED_TYPE")]
    public Insudb.TABLE269? TABLE269 { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SCAREN_TYPE { get; set; }

    [ForeignKey("SCAREN_TYPE")]
    public Insudb.TABLE52? TABLE52 { get; set; }
    public int? NCAREN_QUANT { get; set; }
    public int? NOFFICE_PROD { get; set; }

    [ForeignKey("NOFFICE_PROD")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public decimal? NAMOUNT_COPAY { get; set; }
    public decimal? NFRANCFIX { get; set; }
    public int? NAGESTART { get; set; }
    public int? NAGEEND { get; set; }
    public string? SSEXCLIEN { get; set; }

    [ForeignKey("SSEXCLIEN")]
    public Insudb.TABLE18? TABLE18 { get; set; }
    public int? NPROVIDER { get; set; }

    [ForeignKey("NPROVIDER")]
    public Insudb.TAB_PROVIDER? TAB_PROVIDER { get; set; }
    public int? NATTENSYSTEM { get; set; }

    [ForeignKey("NATTENSYSTEM")]
    public Insudb.TABLE9215? TABLE9215 { get; set; }
    public long? NTYPEEXHAUS { get; set; }

    [ForeignKey("NTYPEEXHAUS")]
    public Insudb.TABLE9221? TABLE9221 { get; set; }
    public string? SILLNESS { get; set; }

    [ForeignKey("SILLNESS")]
    public Insudb.TAB_AM_ILL? TAB_AM_ILL { get; set; }
    public string? SCLARIFICACT { get; set; }
    public int? NBENEFCATEG { get; set; }
    public string? SBENEFCATEG_CODE { get; set; }
    public string? SPRINT_DES { get; set; }
    public int? NIDMEDBENEF { get; set; }
}
