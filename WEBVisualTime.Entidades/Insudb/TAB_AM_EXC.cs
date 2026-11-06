#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_AM_EXC
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
    public int NTARIFF { get; set; }
    public string SILLNESS { get; set; }

    [ForeignKey("SILLNESS")]
    public Insudb.TAB_AM_ILL? TAB_AM_ILL { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NID { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int? NEXC_CODE { get; set; }

    [ForeignKey("NEXC_CODE")]
    public Insudb.TABLE271? TABLE271 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public DateTime? DINIT_DATE { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int NUSERCODE { get; set; }
    public DateTime? DEND_DATE { get; set; }
    public string? STYPE_EXC { get; set; }
    public int? NMODULEC { get; set; }
    public int? NCOVER { get; set; }
    public string? SPREEXISTING { get; set; }
    public string? SCARENCY { get; set; }
    public string? SPERMANENT { get; set; }
    public string? SDESCRIPT { get; set; }
    public long? NMOVEMENT { get; set; }
    public string? SSEL { get; set; }
    public long? NMOVEMENT_NULL { get; set; }
}
