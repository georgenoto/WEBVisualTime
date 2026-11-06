using WEBVisualTime.Servicios.Insudb.DTOs.TABLE200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE200Controller : CatalogController<TABLE200Dto, CreateTABLE200Dto, UpdateTABLE200Dto, int>
{
    public TABLE200Controller(ITABLE200Service service)
        : base(service, "TABLE200", "NINT_STATUS", new[] { "NINT_STATUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
