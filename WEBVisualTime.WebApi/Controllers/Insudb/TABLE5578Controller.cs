using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5578;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5578Controller : CrudApiController<TABLE5578Dto, CreateTABLE5578Dto, UpdateTABLE5578Dto, int>
{
    public TABLE5578Controller(ITABLE5578Service service) : base(service, dto => dto.NACTION) { }
}
