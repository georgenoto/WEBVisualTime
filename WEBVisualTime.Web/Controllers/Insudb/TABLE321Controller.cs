using WEBVisualTime.Servicios.Insudb.DTOs.TABLE321;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE321Controller : CatalogController<TABLE321Dto, CreateTABLE321Dto, UpdateTABLE321Dto, int>
{
    public TABLE321Controller(ITABLE321Service service)
        : base(service, "TABLE321", "NFUNCTION", new[] { "NFUNCTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
