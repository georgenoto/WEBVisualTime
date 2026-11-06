using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5606;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5606Controller : CatalogController<TABLE5606Dto, CreateTABLE5606Dto, UpdateTABLE5606Dto, int>
{
    public TABLE5606Controller(ITABLE5606Service service)
        : base(service, "TABLE5606", "NFACTOR", new[] { "NFACTOR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
