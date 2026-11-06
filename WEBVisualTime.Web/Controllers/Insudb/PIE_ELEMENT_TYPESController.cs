using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class PIE_ELEMENT_TYPESController : CatalogController<PIE_ELEMENT_TYPESDto, CreatePIE_ELEMENT_TYPESDto, UpdatePIE_ELEMENT_TYPESDto, string>
{
    public PIE_ELEMENT_TYPESController(IPIE_ELEMENT_TYPESService service)
        : base(service, "PIE_ELEMENT_TYPES", "SHORT_NAME", new[] { "DISPLAY_NAME", "NAME", "RM_ID", "PLURAL", "GIF_FILE", "ROOT_PROCEDURE", "SHORT_NAME", "DETAIL_PROCEDURE", "DISPLAY_SEQUENCE" }) { }
}
