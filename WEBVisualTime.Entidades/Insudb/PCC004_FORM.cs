#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class PCC004_FORM
{
    public long NNUM_PCC004 { get; set; }
    public DateTime? DISSUEDATFORM { get; set; }
    public string? SLEGALNAME_COMPANY { get; set; }
    public string? SCLINUMDOCU_COMPANY { get; set; }
    public string? SDESCADD_COMPANY { get; set; }
    public int? NLOCAL_COMPANY { get; set; }
    public string? SZONA_COMPANY { get; set; }
    public string? SPHONE_COMPANY { get; set; }
    public int? NPERSON_TYP { get; set; }
    public string? SFIRSTNAME { get; set; }
    public string? SLASTNAME { get; set; }
    public string? SLASTNAME2 { get; set; }
    public int? NTYPCLIENTDOC { get; set; }
    public string? SCLINUMDOCU { get; set; }
    public string? SIDCOMPL { get; set; }
    public int? NNATIONALITY { get; set; }
    public int? NTITLE { get; set; }
    public int? NRESIDENCECOUNTRY { get; set; }
    public long? NSPECIALITY { get; set; }
    public string? SCOMPANYWORKS { get; set; }
    public int? NPOSITION_CLI { get; set; }
    public string? SDESCADD_LABOUR { get; set; }
    public string? SLEGALNAME { get; set; }
    public long? NAREA { get; set; }
    public int? NLOCAL { get; set; }
    public string? SZONA { get; set; }
    public string? SDESCADD_DOMICILE { get; set; }
    public string? SPHONE { get; set; }
    public int? NIND_OPERATION { get; set; }
    public int? NIND_PREMIUMCLAIM { get; set; }
    public int? NIND_INSURANCE { get; set; }
    public int? NIND_TERM { get; set; }
    public int? NCURRENCY { get; set; }
    public string? SCLIENAME_INTERMEDIARY { get; set; }
    public string? SCLIENAME_TITULAR { get; set; }
    public int? NIND_BRANCH { get; set; }
    public long? NPOLICY { get; set; }
    public string? SBANKACCOUNT { get; set; }
    public string? SCHEQUE { get; set; }
    public long? NBANKEXT { get; set; }
    public long? NINDREPOSITION { get; set; }
    public string? SORIGENRESOURCES { get; set; }
    public string? SDESTINYRESOURCES { get; set; }
    public int? NUSERCODE { get; set; }
    public DateTime? DCOMPDATE { get; set; }
    public long? NSETTLEMENT_NUM { get; set; }
    public long? NBORDEREAUX { get; set; }
    public decimal? NACCUMULATED_PAY { get; set; }
    public string? SREMARKS { get; set; }
    public string? SPHONE_PART { get; set; }
    public int? NLOCAL_PART { get; set; }
    public string? SZONE_PART { get; set; }
    public string? SCLIENAME_BROKER { get; set; }
    public string? NIND_CASHFLOW { get; set; }
    public string? SDESCRIPT_CITY { get; set; }
    public string? SDESPOLICY { get; set; }
}
