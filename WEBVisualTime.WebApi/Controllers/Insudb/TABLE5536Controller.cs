using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5536;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5536Controller : CrudApiController<TABLE5536Dto, CreateTABLE5536Dto, UpdateTABLE5536Dto, int>
{
    public TABLE5536Controller(ITABLE5536Service service) : base(service, dto => dto.NSTRUCTURE_WALL) { }
}
