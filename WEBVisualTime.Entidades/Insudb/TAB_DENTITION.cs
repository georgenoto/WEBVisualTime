#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TAB_DENTITION
{
    public int NIDDENTITION { get; set; }
    public string SADA { get; set; }
    public string SFDI { get; set; }
    public int? NTHETH { get; set; }
    public int? NQUADRANT { get; set; }
    public int? NARCADE { get; set; }
    public string? STOOTHNAM { get; set; }
    public string? SPALATINE { get; set; }
    public string? SLINGUAL { get; set; }
    public string? SVESTIBULAR { get; set; }
    public string? SMESIAL { get; set; }
    public string? SDISTAL { get; set; }
    public string? SINCISAL { get; set; }
    public string? SOCLUSAL { get; set; }
    public string? SLABIAL { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
