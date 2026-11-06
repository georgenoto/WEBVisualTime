using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9262Controller : CatalogController<TABLE9262Dto, CreateTABLE9262Dto, UpdateTABLE9262Dto, int>
{
    public TABLE9262Controller(ITABLE9262Service service)
        : base(service, "TABLE9262", "NCLAIM_ENTITY", new[] { "NCLAIM_ENTITY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
