using WEBVisualTime.Servicios.Insudb.DTOs.TABLE16;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE16Controller : CatalogController<TABLE16Dto, CreateTABLE16Dto, UpdateTABLE16Dto, long>
{
    public TABLE16Controller(ITABLE16Service service)
        : base(service, "TABLE16", "NSPECIALITY", new[] { "NSPECIALITY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
