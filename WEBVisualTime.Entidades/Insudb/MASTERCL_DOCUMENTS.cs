#nullable enable
using System.ComponentModel.DataAnnotations.Schema;
namespace WEBVisualTime.Entidades.Insudb;

public partial class MASTERCL_DOCUMENTS
{
    public long NMASTERORDER { get; set; }
    public long NCONSEC_MASTERORDERDOC { get; set; }
    public int NCASE_NUM { get; set; }
    public int NDEMAN_TYPE { get; set; }
    public string SCLIENT { get; set; }
    public int NID { get; set; }
    public int NDOC_CODE { get; set; }
    public long NCONSEC { get; set; }
    public int NAPPLY { get; set; }
    public DateTime DCOMPDATE { get; set; }
    public int NUSERCODE { get; set; }
}
