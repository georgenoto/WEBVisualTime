using WEBVisualTime.Servicios.Insudb.DTOs.TABLE270;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE270Controller : CatalogController<TABLE270Dto, CreateTABLE270Dto, UpdateTABLE270Dto, int>
{
    public TABLE270Controller(ITABLE270Service service)
        : base(service, "TABLE270", "NBENEF_TYPE", new[] { "NBENEF_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
