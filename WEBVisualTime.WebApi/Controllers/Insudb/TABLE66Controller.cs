using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE66Controller : CrudApiController<TABLE66Dto, CreateTABLE66Dto, UpdateTABLE66Dto, int>
{
    public TABLE66Controller(ITABLE66Service service) : base(service, dto => dto.NCOUNTRY) { }
}
