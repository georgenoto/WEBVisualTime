using WEBVisualTime.Servicios.Insudb.DTOs.TABLE300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE300Controller : CatalogController<TABLE300Dto, CreateTABLE300Dto, UpdateTABLE300Dto, long>
{
    public TABLE300Controller(ITABLE300Service service)
        : base(service, "TABLE300", "NCODIGINT", new[] { "NCODIGINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
