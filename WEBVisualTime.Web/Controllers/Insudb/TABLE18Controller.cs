using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE18Controller : CatalogController<TABLE18Dto, CreateTABLE18Dto, UpdateTABLE18Dto, string>
{
    public TABLE18Controller(ITABLE18Service service)
        : base(service, "TABLE18", "SSEXCLIEN", new[] { "SSEXCLIEN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
