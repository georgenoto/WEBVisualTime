using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1007Controller : CatalogController<TABLE1007Dto, CreateTABLE1007Dto, UpdateTABLE1007Dto, long>
{
    public TABLE1007Controller(ITABLE1007Service service)
        : base(service, "TABLE1007", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
