using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9239;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9239Controller : CatalogController<TABLE9239Dto, CreateTABLE9239Dto, UpdateTABLE9239Dto, int>
{
    public TABLE9239Controller(ITABLE9239Service service)
        : base(service, "TABLE9239", "NREJECT_CAUSE", new[] { "NREJECT_CAUSE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
