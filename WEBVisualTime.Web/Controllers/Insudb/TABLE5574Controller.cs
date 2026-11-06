using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5574;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5574Controller : CatalogController<TABLE5574Dto, CreateTABLE5574Dto, UpdateTABLE5574Dto, int>
{
    public TABLE5574Controller(ITABLE5574Service service)
        : base(service, "TABLE5574", "NSENDADDR", new[] { "NSENDADDR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
