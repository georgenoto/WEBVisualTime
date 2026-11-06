using WEBVisualTime.Servicios.Insudb.DTOs.TABLE401;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE401Controller : CrudApiController<TABLE401Dto, CreateTABLE401Dto, UpdateTABLE401Dto, int>
{
    public TABLE401Controller(ITABLE401Service service) : base(service, dto => dto.NTYPE_MOVE) { }
}
