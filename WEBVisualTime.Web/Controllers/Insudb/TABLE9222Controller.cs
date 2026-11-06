using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9222;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9222Controller : CatalogController<TABLE9222Dto, CreateTABLE9222Dto, UpdateTABLE9222Dto, int>
{
    public TABLE9222Controller(ITABLE9222Service service)
        : base(service, "TABLE9222", "NBENEFCATEG", new[] { "NBENEFCATEG", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
