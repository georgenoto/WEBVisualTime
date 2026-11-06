using WEBVisualTime.Servicios.Insudb.DTOs.TABLE695;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE695Controller : CatalogController<TABLE695Dto, CreateTABLE695Dto, UpdateTABLE695Dto, int>
{
    public TABLE695Controller(ITABLE695Service service)
        : base(service, "TABLE695", "NSYSMODUL", new[] { "NSYSMODUL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
