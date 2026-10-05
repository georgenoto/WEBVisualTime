#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COMMPAYREQ_ORDERS
{
    public long NID_COMMPAYREQ { get; set; }

    [ForeignKey("NID_COMMPAYREQ")]
    public Insudb.COMMPAYMENTREQUESTS? COMMPAYMENTREQUESTS { get; set; }
    public long NCLAIM { get; set; }

    [ForeignKey("NCLAIM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCLAIM { get; set; }
    public int NCASE_NUM { get; set; }

    [ForeignKey("NCASE_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }

    [ForeignKey("NDEMAN_TYPE")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNDEMAN_TYPE { get; set; }
    public long NORDER_NUM { get; set; }

    [ForeignKey("NORDER_NUM")]
    public Insudb.CLAIM_ORDER? CLAIM_ORDERNORDER_NUM { get; set; }
    public long NMASTERORDER { get; set; }

    [ForeignKey("NMASTERORDER")]
    public Insudb.MASTERCL_ORDER? MASTERCL_ORDER { get; set; }
    public int NMASTERORDERTYPE { get; set; }

    [ForeignKey("NMASTERORDERTYPE")]
    public Insudb.TABLE9265? TABLE9265 { get; set; }
    public string? STYPECARE { get; set; }

    [ForeignKey("STYPECARE")]
    public Insudb.TABLE8604? TABLE8604 { get; set; }
    public string? DIAGNOSIS_ORDER { get; set; }
    public string? REASONREJECT_ORDER { get; set; }
    public int NCURRENCY_MO { get; set; }

    [ForeignKey("NCURRENCY_MO")]
    public Insudb.TABLE11? TABLE11 { get; set; }
    public decimal? NAMOUNTREJECTED_ORDER { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }

    [ForeignKey("NUSERCODE")]
    public Insudb.USERS? USERS { get; set; }
    public int NSTATUS_ORDER { get; set; }

    [ForeignKey("NSTATUS_ORDER")]
    public Insudb.TABLE9241? TABLE9241 { get; set; }
}
