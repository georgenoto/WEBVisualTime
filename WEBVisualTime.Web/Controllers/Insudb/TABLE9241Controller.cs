using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9241Controller : CatalogController<TABLE9241Dto, CreateTABLE9241Dto, UpdateTABLE9241Dto, int>
{
    public TABLE9241Controller(ITABLE9241Service service)
        : base(service, "TABLE9241", "NSTATUS_ORDER", new[] { "NSTATUS_ORDER", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
