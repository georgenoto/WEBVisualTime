using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7044;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7044Controller : CatalogController<TABLE7044Dto, CreateTABLE7044Dto, UpdateTABLE7044Dto, int>
{
    public TABLE7044Controller(ITABLE7044Service service)
        : base(service, "TABLE7044", "NACTIVITYCAT", new[] { "NACTIVITYCAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
