using WEBVisualTime.Servicios.Insudb.DTOs.TABLE96;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE96Controller : CatalogController<TABLE96Dto, CreateTABLE96Dto, UpdateTABLE96Dto, long>
{
    public TABLE96Controller(ITABLE96Service service)
        : base(service, "TABLE96", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
