#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class TABLE340
{
    public int NFREQMAXEVEN { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public string SDESCRIPT { get; set; }
    public string SSHORT_DES { get; set; }
    public string SSTATREGT { get; set; }
    public int NUSERCODE { get; set; }
}
