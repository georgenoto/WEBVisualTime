using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8090;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8090Controller : CatalogController<TABLE8090Dto, CreateTABLE8090Dto, UpdateTABLE8090Dto, int>
{
    public TABLE8090Controller(ITABLE8090Service service)
        : base(service, "TABLE8090", "NSERIES", new[] { "NSERIES", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
