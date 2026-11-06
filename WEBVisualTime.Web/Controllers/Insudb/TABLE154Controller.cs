using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE154Controller : CatalogController<TABLE154Dto, CreateTABLE154Dto, UpdateTABLE154Dto, string>
{
    public TABLE154Controller(ITABLE154Service service)
        : base(service, "TABLE154", "SREVALAPL", new[] { "SREVALAPL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
