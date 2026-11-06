using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5613;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5613Controller : CatalogController<TABLE5613Dto, CreateTABLE5613Dto, UpdateTABLE5613Dto, int>
{
    public TABLE5613Controller(ITABLE5613Service service)
        : base(service, "TABLE5613", "NCONTAINRISK", new[] { "NCONTAINRISK", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
