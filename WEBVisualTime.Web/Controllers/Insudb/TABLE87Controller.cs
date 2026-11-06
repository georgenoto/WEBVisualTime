using WEBVisualTime.Servicios.Insudb.DTOs.TABLE87;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE87Controller : CatalogController<TABLE87Dto, CreateTABLE87Dto, UpdateTABLE87Dto, int>
{
    public TABLE87Controller(ITABLE87Service service)
        : base(service, "TABLE87", "NMODULES", new[] { "NMODULES", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
