using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_ITEMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_HELP_ITEMSController : CatalogController<ODWA_HELP_ITEMSDto, CreateODWA_HELP_ITEMSDto, UpdateODWA_HELP_ITEMSDto, int>
{
    public ODWA_HELP_ITEMSController(IODWA_HELP_ITEMSService service)
        : base(service, "ODWA_HELP_ITEMS", "ID", new[] { "ID", "DESCRIPTION", "DOCUMENT", "KEYWORDS" }) { }
}
