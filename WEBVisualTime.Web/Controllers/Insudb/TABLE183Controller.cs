using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE183Controller : CatalogController<TABLE183Dto, CreateTABLE183Dto, UpdateTABLE183Dto, int>
{
    public TABLE183Controller(ITABLE183Service service)
        : base(service, "TABLE183", "NCARD_TYPE", new[] { "NCARD_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
