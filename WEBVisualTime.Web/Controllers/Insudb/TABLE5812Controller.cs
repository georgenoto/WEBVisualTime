using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5812;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5812Controller : CatalogController<TABLE5812Dto, CreateTABLE5812Dto, UpdateTABLE5812Dto, int>
{
    public TABLE5812Controller(ITABLE5812Service service)
        : base(service, "TABLE5812", "NDOC_CODE", new[] { "NDOC_CODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
