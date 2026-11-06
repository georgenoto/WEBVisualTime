using WEBVisualTime.Servicios.Insudb.DTOs.TABLE560;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE560Controller : CatalogController<TABLE560Dto, CreateTABLE560Dto, UpdateTABLE560Dto, int>
{
    public TABLE560Controller(ITABLE560Service service)
        : base(service, "TABLE560", "NORDCLASS", new[] { "NORDCLASS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
