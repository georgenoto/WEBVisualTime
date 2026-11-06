using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5641;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5641Controller : CatalogController<TABLE5641Dto, CreateTABLE5641Dto, UpdateTABLE5641Dto, int>
{
    public TABLE5641Controller(ITABLE5641Service service)
        : base(service, "TABLE5641", "NINTENTION", new[] { "NINTENTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
