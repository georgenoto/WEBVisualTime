#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class CUENTECN
{
    public int NTYPE_REL { get; set; }
    public long NIDCONSEC { get; set; }
    public int NNUMBER { get; set; }
    public int NTYPE { get; set; }
    public int NBRANCH { get; set; }
    public string STYPE_ACC { get; set; }
    public int NTYPE_PER { get; set; }

    [ForeignKey("NTYPE_PER")]
    public Insudb.TABLE97? TABLE97 { get; set; }
    public int NPERIODY { get; set; }
    public int NCURRENCY { get; set; }
    public decimal? NCLAIM_CED { get; set; }
    public decimal? NCLAIM_REC { get; set; }
    public long? NCOMISION { get; set; }
    public int? NCOMPANY { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public decimal? NDEV_RESCLA { get; set; }
    public decimal? NDEV_RESPRE { get; set; }
    public decimal? NE_CAR_PREM { get; set; }
    public decimal? NE_CAR_SIN { get; set; }
    public DateTime? DEFFECDATE { get; set; }
    public decimal? NGASTO_REAS { get; set; }
    public long? NIMPUESTO { get; set; }
    public long? NINTER_PREM { get; set; }
    public long? NINTER_SIN { get; set; }
    public string? SMOVE_ACC { get; set; }
    public DateTime? DNULLDATE { get; set; }
    public decimal? NPART_BENEF { get; set; }
    public decimal? NPREM_ANU { get; set; }
    public decimal? NPREM_CED { get; set; }
    public decimal? NPREM_NO_AN { get; set; }
    public decimal? NPREM_RES_A { get; set; }
    public string? SPRINT { get; set; }
    public decimal? NR_CAR_PREM { get; set; }
    public decimal? NR_CAR_SIN { get; set; }
    public decimal? NRES_AJ_SIN { get; set; }
    public decimal? NRES_SINPEN { get; set; }
    public decimal? NRET_RESPRE { get; set; }
    public decimal? NSAL_F_COMP { get; set; }
    public decimal? NSAL_F_REIN { get; set; }
    public decimal? NCLAIMAMO { get; set; }
    public int? NUSERCODE { get; set; }
    public int? NYEAR { get; set; }
    public int? NYEAR_SER { get; set; }
    public string? SACTIVE { get; set; }
    public long? NREQUESTNU { get; set; }
    public DateTime? DDATEPAY { get; set; }
    public DateTime? DLEDGERDAT { get; set; }
    public DateTime? DPOSTED { get; set; }
    public long? NCORREDOR { get; set; }
    public decimal? NTAXAMOUNT { get; set; }
    public decimal? NCITY_TAX { get; set; }
    public decimal? NISLR_TAX { get; set; }
    public decimal? NSUPER_TAX { get; set; }
    public decimal? NTECH_TAX { get; set; }
    public decimal? NSHARE { get; set; }
    public decimal? NAMOUNT_BENEF { get; set; }
}
