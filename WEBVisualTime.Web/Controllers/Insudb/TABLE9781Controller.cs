using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9781;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9781Controller : CatalogController<TABLE9781Dto, CreateTABLE9781Dto, UpdateTABLE9781Dto, int>
{
    public TABLE9781Controller(ITABLE9781Service service)
        : base(service, "TABLE9781", "NSYSTEM", new[] { "NSYSTEM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
