using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5578;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5578Controller : CatalogController<TABLE5578Dto, CreateTABLE5578Dto, UpdateTABLE5578Dto, int>
{
    public TABLE5578Controller(ITABLE5578Service service)
        : base(service, "TABLE5578", "NACTION", new[] { "NACTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
