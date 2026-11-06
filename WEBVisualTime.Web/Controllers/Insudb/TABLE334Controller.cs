using WEBVisualTime.Servicios.Insudb.DTOs.TABLE334;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE334Controller : CatalogController<TABLE334Dto, CreateTABLE334Dto, UpdateTABLE334Dto, int>
{
    public TABLE334Controller(ITABLE334Service service)
        : base(service, "TABLE334", "NSTATUS", new[] { "NSTATUS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
