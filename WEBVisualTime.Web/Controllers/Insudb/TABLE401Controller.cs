using WEBVisualTime.Servicios.Insudb.DTOs.TABLE401;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE401Controller : CatalogController<TABLE401Dto, CreateTABLE401Dto, UpdateTABLE401Dto, int>
{
    public TABLE401Controller(ITABLE401Service service)
        : base(service, "TABLE401", "NTYPE_MOVE", new[] { "NTYPE_MOVE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
