using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5555;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5555Controller : CrudApiController<TABLE5555Dto, CreateTABLE5555Dto, UpdateTABLE5555Dto, int>
{
    public TABLE5555Controller(ITABLE5555Service service) : base(service, dto => dto.NAGENCY) { }
}
