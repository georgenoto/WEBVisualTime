using WEBVisualTime.Servicios.Insudb.DTOs.PIE_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class PIE_ELEMENT_TYPESController : CrudApiController<PIE_ELEMENT_TYPESDto, CreatePIE_ELEMENT_TYPESDto, UpdatePIE_ELEMENT_TYPESDto, string>
{
    public PIE_ELEMENT_TYPESController(IPIE_ELEMENT_TYPESService service) : base(service, dto => dto.SHORT_NAME) { }
}
