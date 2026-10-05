#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class DIR_DEBIT
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
    public DateTime DEFFECDATE { get; set; }
    public string? SACCOUNT { get; set; }
    public long NBANKEXT { get; set; }

    [ForeignKey("NBANKEXT")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public string? SCREDI_CARD { get; set; }
    public int NTYP_CRECARD { get; set; }

    [ForeignKey("NTYP_CRECARD")]
    public Insudb.TABLE183? TABLE183 { get; set; }
    public string? STYP_DIRDEB { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCARDEXPIR { get; set; }
    public string? SBANKAUTH { get; set; }
    public string SREUSE { get; set; }
    public int? NTYP_ACC { get; set; }
    public int? NSTATUS_BANKAUTH { get; set; }
    public long? NIDCOLLECT { get; set; }
    public int? NBILL_DAYINI { get; set; }
    public DateTime? DBANKAUTH { get; set; }
    public string? SDEBIT_CARD { get; set; }
    public int? NBILL_DAYEND { get; set; }
}
