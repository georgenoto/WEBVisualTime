using WEBVisualTime.Servicios.Insudb.DTOs.TABLE640;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE640Controller : CatalogController<TABLE640Dto, CreateTABLE640Dto, UpdateTABLE640Dto, int>
{
    public TABLE640Controller(ITABLE640Service service)
        : base(service, "TABLE640", "NECON_AREA", new[] { "NECON_AREA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
