using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5596;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5596Controller : CrudApiController<TABLE5596Dto, CreateTABLE5596Dto, UpdateTABLE5596Dto, int>
{
    public TABLE5596Controller(ITABLE5596Service service) : base(service, dto => dto.NMATERPIPE) { }
}
