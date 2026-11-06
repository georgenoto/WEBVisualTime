#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class INTERMEDIA
{
    public long NINTERMED { get; set; }
    public string? SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public int? NCOMTABGE { get; set; }
    public int? NCOMTABLI { get; set; }

    [ForeignKey("NCOMTABLI")]
    public Insudb.TAB_COMLIF? TAB_COMLIF { get; set; }
    public DateTime? DINPDATE { get; set; }
    public int? NINT_STATUS { get; set; }

    [ForeignKey("NINT_STATUS")]
    public Insudb.TABLE200? TABLE200 { get; set; }
    public int? NINTERTYP { get; set; }

    [ForeignKey("NINTERTYP")]
    public Insudb.INTERM_TYP? INTERM_TYP { get; set; }
    public int? NNULLCODE { get; set; }

    [ForeignKey("NNULLCODE")]
    public Insudb.TABLE163? TABLE163 { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public int? NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public long? NSUPERVIS { get; set; }
    public int? NTABLE_COD { get; set; }
    public decimal? NTAX { get; set; }
    public int? NUSERCODE { get; set; }
    public string? SCOL_AGREE { get; set; }
    public long? NNOTENUM { get; set; }
    public int? NECO_SCHE { get; set; }

    [ForeignKey("NECO_SCHE")]
    public Insudb.DISEX_INT_M? DISEX_INT_M { get; set; }
    public string? SINTER_ID { get; set; }
    public string? SAGREEINT { get; set; }
    public string? SLIFE { get; set; }
    public string? SNONLIFE { get; set; }
    public int? NLIFE_SCHE { get; set; }

    [ForeignKey("NLIFE_SCHE")]
    public Insudb.TABLE5500? TABLE5500NLIFE_SCHE { get; set; }
    public int? NGEN_SCHE { get; set; }

    [ForeignKey("NGEN_SCHE")]
    public Insudb.TABLE5500? TABLE5500NGEN_SCHE { get; set; }
    public int? NLEGAL_SCH { get; set; }

    [ForeignKey("NLEGAL_SCH")]
    public Insudb.TABLE5501? TABLE5501 { get; set; }
    public long? NSUP_GEN { get; set; }
    public long? NINSU_ASSIST { get; set; }
    public int? NGOAL_GEN { get; set; }
    public int? NGOAL_LIFE { get; set; }
    public long? NINSU_ASSISTLIF { get; set; }
    public int? NAGENCY { get; set; }

    [ForeignKey("NAGENCY")]
    public Insudb.TABLE5555? TABLE5555 { get; set; }
    public int? NOFFICEAGEN { get; set; }

    [ForeignKey("NOFFICEAGEN")]
    public Insudb.TABLE5556? TABLE5556 { get; set; }
    public int? NSLC_TAB_NR { get; set; }
    public DateTime? DCOMMIDATE { get; set; }
    public string? SVALID { get; set; }
    public int? NCONTRAT { get; set; }
    public int? NRECEPTYP { get; set; }

    [ForeignKey("NRECEPTYP")]
    public Insudb.TABLE9211? TABLE9211 { get; set; }
    public int? NCOM_CHANNEL { get; set; }
    public string? SPERSIS { get; set; }
    public int? NUSER_RETENC { get; set; }
    public DateTime? DDATE_RETENC { get; set; }
    public int? NUSER_LIBRET { get; set; }
    public DateTime? DDATE_LIBRET { get; set; }
    public string? SCODAGENT_SCAB { get; set; }
}
