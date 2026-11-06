using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5642;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5642Controller : CatalogController<TABLE5642Dto, CreateTABLE5642Dto, UpdateTABLE5642Dto, int>
{
    public TABLE5642Controller(ITABLE5642Service service)
        : base(service, "TABLE5642", "NCHANGESDAT", new[] { "NCHANGESDAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
