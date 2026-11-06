using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE90Controller : CatalogController<TABLE90Dto, CreateTABLE90Dto, UpdateTABLE90Dto, string>
{
    public TABLE90Controller(ITABLE90Service service)
        : base(service, "TABLE90", "SCUMREINT", new[] { "SCUMREINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
