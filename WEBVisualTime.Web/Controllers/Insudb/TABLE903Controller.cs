using WEBVisualTime.Servicios.Insudb.DTOs.TABLE903;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE903Controller : CatalogController<TABLE903Dto, CreateTABLE903Dto, UpdateTABLE903Dto, int>
{
    public TABLE903Controller(ITABLE903Service service)
        : base(service, "TABLE903", "NSTAINFCASE", new[] { "NSTAINFCASE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
