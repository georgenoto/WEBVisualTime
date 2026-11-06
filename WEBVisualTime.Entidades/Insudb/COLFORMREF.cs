#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COLFORMREF
{
    public long NBORDEREAUX { get; set; }
    public string? STYPE { get; set; }
    public long? NBANK { get; set; }

    [ForeignKey("NBANK")]
    public Insudb.TABLE7? TABLE7 { get; set; }
    public long? NINTERMED { get; set; }

    [ForeignKey("NINTERMED")]
    public Insudb.INTERMEDIA? INTERMEDIA { get; set; }
    public decimal? NREL_AMOUN { get; set; }
    public int? NCURRENCY { get; set; }
    public long? NPOLICY { get; set; }
    public DateTime? DCOLLECT { get; set; }
    public int? NBRANCH { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public int? NPRODUCT { get; set; }
    public string? SREL_TYPE { get; set; }

    [ForeignKey("SREL_TYPE")]
    public Insudb.TABLE7502? TABLE7502 { get; set; }
    public string? SSTATUS { get; set; }
    public long? NCERTIF { get; set; }
    public string? SCONWIN { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public int NUSER_AMEND { get; set; }
    public int? NCASHNUM { get; set; }
    public int NINPUTTYP { get; set; }

    [ForeignKey("NINPUTTYP")]
    public Insudb.TABLE5554? TABLE5554 { get; set; }
    public int NINSUR_AREA { get; set; }

    [ForeignKey("NINSUR_AREA")]
    public Insudb.TABLE5001? TABLE5001 { get; set; }
    public int? NAGREEMENT { get; set; }
    public DateTime DVALUEDATE { get; set; }
    public string? SIND_ANNUITY { get; set; }
    public DateTime? DDATE_BENLAR { get; set; }
    public long? NCOLLECTOR { get; set; }

    [ForeignKey("NCOLLECTOR")]
    public Insudb.COLLECTOR? COLLECTOR { get; set; }
    public string? SRELORIGI { get; set; }
    public DateTime? DCOLLECTDATE { get; set; }
    public long? NBILLNUM { get; set; }
    public decimal? NRETENTION { get; set; }
    public decimal? NTAXRETENTION { get; set; }
    public int? NNULLCODE { get; set; }
    public long? NNOTENUM { get; set; }
    public long? NIMAGENUM { get; set; }
}
