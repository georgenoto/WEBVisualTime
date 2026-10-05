#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class COVERCOL_TMP
{
    public string SCERTYPE { get; set; }
    public int NBRANCH { get; set; }
    public int NPRODUCT { get; set; }
    public long NPOLICY { get; set; }
    public long NCERTIF { get; set; }
    public long NIDCONSEC { get; set; }
    public long NROW { get; set; }
    public long NCOLUMN { get; set; }
    public string? STITTLE { get; set; }
    public string? SVALUE { get; set; }
    public string? SVALUE1 { get; set; }
    public string? SVALUE2 { get; set; }
    public string? SVALUE3 { get; set; }
    public string? SVALUE4 { get; set; }
    public string? SVALUE5 { get; set; }
    public string? SVALUE6 { get; set; }
    public string? SVALUE7 { get; set; }
    public string? SVALUE8 { get; set; }
    public string? SVALUE9 { get; set; }
    public string? STYPE { get; set; }
    public string? SDATATYPE { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
    public string? SMATERNITY { get; set; }
}
