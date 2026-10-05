#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_AM_EXC
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE")]
    public Insudb.CERTIFICAT? CERTIFICATSCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [ForeignKey("NBRANCH")]
    public Insudb.CERTIFICAT? CERTIFICATNBRANCH { get; set; }
    public int NPRODUCT { get; set; }

    [ForeignKey("NPRODUCT")]
    public Insudb.CERTIFICAT? CERTIFICATNPRODUCT { get; set; }
    public long NPOLICY { get; set; }

    [ForeignKey("NPOLICY")]
    public Insudb.CERTIFICAT? CERTIFICATNPOLICY { get; set; }
    public long NCERTIF { get; set; }

    [ForeignKey("NCERTIF")]
    public Insudb.CERTIFICAT? CERTIFICATNCERTIF { get; set; }
    public int NTARIFF { get; set; }
    public string SILLNESS { get; set; }

    [ForeignKey("SILLNESS")]
    public Insudb.TAB_AM_ILL? TAB_AM_ILL { get; set; }
    public DateTime DEFFECDATE { get; set; }
    public int NID { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NEXC_CODE { get; set; }

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
