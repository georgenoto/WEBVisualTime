using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5591;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5591Controller : CrudApiController<TABLE5591Dto, CreateTABLE5591Dto, UpdateTABLE5591Dto, int>
{
    public TABLE5591Controller(ITABLE5591Service service) : base(service, dto => dto.NCARDINAL) { }
}
