using WEBVisualTime.Servicios.Insudb.DTOs.TABLE694;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE694Controller : CatalogController<TABLE694Dto, CreateTABLE694Dto, UpdateTABLE694Dto, int>
{
    public TABLE694Controller(ITABLE694Service service)
        : base(service, "TABLE694", "NINTCALC", new[] { "NINTCALC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
