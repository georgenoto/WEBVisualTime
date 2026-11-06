using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_PREFERENCES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_PREFERENCESController : CatalogController<ODWA_PREFERENCESDto, CreateODWA_PREFERENCESDto, UpdateODWA_PREFERENCESDto, string>
{
    public ODWA_PREFERENCESController(IODWA_PREFERENCESService service)
        : base(service, "ODWA_PREFERENCES", "PREFERENCE_NAME", new[] { "PREFERENCE_NAME", "PREFERENCE_VALUE", "PREFERENCE_DESCRIPTION" }) { }
}
