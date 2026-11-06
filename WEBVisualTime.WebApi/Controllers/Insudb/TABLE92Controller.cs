using WEBVisualTime.Servicios.Insudb.DTOs.TABLE92;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE92Controller : CrudApiController<TABLE92Dto, CreateTABLE92Dto, UpdateTABLE92Dto, string>
{
    public TABLE92Controller(ITABLE92Service service) : base(service, dto => dto.STYP_VAR) { }
}
