using WEBVisualTime.Servicios.Insudb.DTOs.TABLE72;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE72Controller : CatalogController<TABLE72Dto, CreateTABLE72Dto, UpdateTABLE72Dto, int>
{
    public TABLE72Controller(ITABLE72Service service)
        : base(service, "TABLE72", "NREQEXC", new[] { "NREQEXC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
