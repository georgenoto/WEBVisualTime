using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5536;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5536Controller : CatalogController<TABLE5536Dto, CreateTABLE5536Dto, UpdateTABLE5536Dto, int>
{
    public TABLE5536Controller(ITABLE5536Service service)
        : base(service, "TABLE5536", "NSTRUCTURE_WALL", new[] { "NSTRUCTURE_WALL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
