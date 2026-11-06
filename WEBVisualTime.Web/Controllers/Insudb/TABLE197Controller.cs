using WEBVisualTime.Servicios.Insudb.DTOs.TABLE197;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE197Controller : CatalogController<TABLE197Dto, CreateTABLE197Dto, UpdateTABLE197Dto, int>
{
    public TABLE197Controller(ITABLE197Service service)
        : base(service, "TABLE197", "NAVAIL_TYPE", new[] { "NAVAIL_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
