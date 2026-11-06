using WEBVisualTime.Servicios.Insudb.DTOs.TABLE201;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE201Controller : CatalogController<TABLE201Dto, CreateTABLE201Dto, UpdateTABLE201Dto, int>
{
    public TABLE201Controller(ITABLE201Service service)
        : base(service, "TABLE201", "NTYPEWARRANTY", new[] { "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE", "NTYPEWARRANTY" }) { }
}
