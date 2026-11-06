using WEBVisualTime.Servicios.Insudb.DTOs.TABLE49;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE49Controller : CatalogController<TABLE49Dto, CreateTABLE49Dto, UpdateTABLE49Dto, string>
{
    public TABLE49Controller(ITABLE49Service service)
        : base(service, "TABLE49", "SCOLREINT", new[] { "SCOLREINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
