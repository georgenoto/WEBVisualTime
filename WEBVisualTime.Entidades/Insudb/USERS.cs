#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class USERS
{
    public int NUSERCODE { get; set; }
    public string? SACCESSWO { get; set; }
    public int NOFFICE { get; set; }

    [ForeignKey("NOFFICE")]
    public Insudb.TABLE9? TABLE9 { get; set; }
    public string SCLIENT { get; set; }

    [ForeignKey("SCLIENT")]
    public Insudb.CLIENT? CLIENT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string? SINITIALS { get; set; }
    public string SSCHE_CODE { get; set; }

    [ForeignKey("SSCHE_CODE")]
    public Insudb.SECUR_SCHE? SECUR_SCHE { get; set; }
    public string SSTATREGT { get; set; }
    public string? STYPE { get; set; }

    [ForeignKey("STYPE")]
    public Insudb.TABLE105? TABLE105 { get; set; }
    public int NDEPARTME { get; set; }

    [ForeignKey("NDEPARTME")]
    public Insudb.TABLE84? TABLE84 { get; set; }
    public string? SMENU { get; set; }
    public string? SCHNEXTLOGON { get; set; }
    public string? SNEVERCHANGE { get; set; }
    public string? SNEVEREXPIRES { get; set; }
    public string? SLOCKEDOUT { get; set; }
    public DateTime? DFROMDATE { get; set; }
    public int NOFFICEAGEN { get; set; }
    public int NAGENCY { get; set; }
    public int? NFAILED_LOGON_ATTEMPTS { get; set; }
    public DateTime? DPASSWORD_EXPIRES { get; set; }
}
