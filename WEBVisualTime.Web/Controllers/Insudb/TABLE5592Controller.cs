using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5592;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5592Controller : CatalogController<TABLE5592Dto, CreateTABLE5592Dto, UpdateTABLE5592Dto, int>
{
    public TABLE5592Controller(ITABLE5592Service service)
        : base(service, "TABLE5592", "NTYPENAME", new[] { "NTYPENAME", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
