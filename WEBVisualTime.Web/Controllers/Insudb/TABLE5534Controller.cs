using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5534;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5534Controller : CatalogController<TABLE5534Dto, CreateTABLE5534Dto, UpdateTABLE5534Dto, int>
{
    public TABLE5534Controller(ITABLE5534Service service)
        : base(service, "TABLE5534", "NDAMAG_AUTO", new[] { "NDAMAG_AUTO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
