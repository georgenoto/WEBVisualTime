using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5506;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5506Controller : CrudApiController<TABLE5506Dto, CreateTABLE5506Dto, UpdateTABLE5506Dto, int>
{
    public TABLE5506Controller(ITABLE5506Service service) : base(service, dto => dto.NHOBBY) { }
}
