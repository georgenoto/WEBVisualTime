using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7505Controller : CatalogController<TABLE7505Dto, CreateTABLE7505Dto, UpdateTABLE7505Dto, string>
{
    public TABLE7505Controller(ITABLE7505Service service)
        : base(service, "TABLE7505", "SNULLACTION", new[] { "SNULLACTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
