using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5743;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5743Controller : CatalogController<TABLE5743Dto, CreateTABLE5743Dto, UpdateTABLE5743Dto, int>
{
    public TABLE5743Controller(ITABLE5743Service service)
        : base(service, "TABLE5743", "NTYPE_AMEAPV", new[] { "NTYPE_AMEAPV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
