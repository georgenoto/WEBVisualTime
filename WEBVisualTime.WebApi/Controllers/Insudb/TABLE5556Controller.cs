using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5556;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5556Controller : CrudApiController<TABLE5556Dto, CreateTABLE5556Dto, UpdateTABLE5556Dto, int>
{
    public TABLE5556Controller(ITABLE5556Service service) : base(service, dto => dto.NOFFICEAGEN) { }
}
