#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASTERSHEET
{
    public int NSHEET { get; set; }

    [ForeignKey("NSHEET")]
    public Insudb.MASTERSHEET? MASTERSHEETParent { get; set; }
    public int NINTERTYPE { get; set; }
    public string? SPROCESS { get; set; }
    public int NFORMAT { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int? NSYSTEM { get; set; }
    public string? SSELECT { get; set; }
    public int? NPERIOD { get; set; }
    public int NUSERCODE { get; set; }
    public string SDESCRIPT { get; set; }
    public int? NUSEROPER { get; set; }
    public string SAUTOMATIC { get; set; }
    public string SSHORTDESC { get; set; }
    public string SGROUPBY { get; set; }
    public string? SSTATUSSHEET { get; set; }
    public int? NOPERTYPE { get; set; }
    public string? SONLINE { get; set; }
    public long? NNOTENUM { get; set; }
    public string? SPROCESS_END { get; set; }
    public string? SPREFIX_FNAME { get; set; }
    public string? SHEADER { get; set; }
    public string? STOTAL { get; set; }
    public int? NPOSITION { get; set; }
    public string? SMASSIVE { get; set; }
    public string? SSPACE { get; set; }
    public int? NTYPE_ALIGN { get; set; }
    public string? SPATH { get; set; }
    public string? SSEPARATOR { get; set; }
    public string? SROUTINE { get; set; }
    public string? SNOGRID { get; set; }
    public string? SVIEW_INTERFACE { get; set; }
    public string? SVIEW_REPORT { get; set; }
    public string? SREPORT { get; set; }
    public string? SSHEET_FATHER { get; set; }
    public string? SFILE_UNIQUE { get; set; }
    public string? SQUERY { get; set; }
    public string? SXSL { get; set; }
    public string? SQUERY_XSL { get; set; }
    public string? SNAME_ROUTINE { get; set; }
    public string? SOUT_ROUTINE { get; set; }
    public string? SWORKFLOWNAME { get; set; }
    public string? SFOLDER { get; set; }
    public string? SQUEPROCESS { get; set; }
    public string? SQUEQUERY { get; set; }
    public string? ST_INTERFACE { get; set; }
    public int? NAVERAGERECORDS { get; set; }
    public int? NTOTALCOLUMNS { get; set; }
    public string? SDATEFORMAT { get; set; }
    public string? SDECIMAL { get; set; }
}
