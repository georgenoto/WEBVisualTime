using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5503;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5503Controller : CatalogController<TABLE5503Dto, CreateTABLE5503Dto, UpdateTABLE5503Dto, long>
{
    public TABLE5503Controller(ITABLE5503Service service)
        : base(service, "TABLE5503", "NAREA", new[] { "NAREA", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
