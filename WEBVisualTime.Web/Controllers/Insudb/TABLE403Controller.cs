using WEBVisualTime.Servicios.Insudb.DTOs.TABLE403;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE403Controller : CatalogController<TABLE403Dto, CreateTABLE403Dto, UpdateTABLE403Dto, long>
{
    public TABLE403Controller(ITABLE403Service service)
        : base(service, "TABLE403", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
