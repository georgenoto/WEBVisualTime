using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE135Controller : CatalogController<TABLE135Dto, CreateTABLE135Dto, UpdateTABLE135Dto, string>
{
    public TABLE135Controller(ITABLE135Service service)
        : base(service, "TABLE135", "SSTACLAIM", new[] { "SSTACLAIM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
