#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class OUT_PREMIU
{
    public string SCERTYPE { get; set; }

    [ForeignKey("SCERTYPE, NBRANCH, NPRODUCT, NPOLICY, NCERTIF, NMOVNUMBE, NDIGIT")]
    public Insudb.OUT_MOVEME? OUT_MOVEMESCERTYPE { get; set; }
    public int NBRANCH { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENBRANCH
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public int NPRODUCT { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENPRODUCT
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public long NPOLICY { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENPOLICY
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public long NCERTIF { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENCERTIF
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public long NMOVNUMBE { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENMOVNUMBE
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public int NDIGIT { get; set; }

    [NotMapped]
    public Insudb.OUT_MOVEME? OUT_MOVEMENDIGIT
    {
        get => OUT_MOVEMESCERTYPE;
        set => OUT_MOVEMESCERTYPE = value;
    }
    public int NID_BILL { get; set; }
    public string? SADDSUINI { get; set; }
    public string STYPE_DETAI { get; set; }
    public int? NBILL_ITEM { get; set; }
    public int NCODE_DETAI { get; set; }
    public int NBRANCH_EST { get; set; }
    public int NBRANCH_LED { get; set; }
    public int? NBRANCH_REI { get; set; }
    public decimal? NCAPITAL { get; set; }
    public decimal? NCOMMI_RATE { get; set; }
    public decimal? NCOMMISION { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NPREMIUM { get; set; }
    public decimal? NTAX { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NPROVINCIE { get; set; }
    public decimal? NPREM_ANU { get; set; }
    public decimal? NCOM_ANU { get; set; }
    public decimal? NPREMANUAL { get; set; }
    public string? SADDTAX { get; set; }
    public decimal? NCOMANUAL { get; set; }
    public decimal? NPREMIUMA { get; set; }
    public decimal? NPREMIUME { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NRECAMOUNT { get; set; }
    public decimal? NDESCAMOUNT { get; set; }
    public int? NREL_IDBILL { get; set; }
    public string? SCLIENT { get; set; }
    public int? NDISSUR_TYPE { get; set; }

    [ForeignKey("NDISSUR_TYPE")]
    public Insudb.TABLE9207? TABLE9207 { get; set; }
    public decimal? NCOM_SUPER { get; set; }
    public decimal? NCOMANUAL_SUPER { get; set; }
    public decimal? NCOMSUP_RATE { get; set; }
}
