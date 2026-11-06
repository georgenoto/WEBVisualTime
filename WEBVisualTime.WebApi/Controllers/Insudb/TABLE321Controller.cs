using WEBVisualTime.Servicios.Insudb.DTOs.TABLE321;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE321Controller : CrudApiController<TABLE321Dto, CreateTABLE321Dto, UpdateTABLE321Dto, int>
{
    public TABLE321Controller(ITABLE321Service service) : base(service, dto => dto.NFUNCTION) { }
}
