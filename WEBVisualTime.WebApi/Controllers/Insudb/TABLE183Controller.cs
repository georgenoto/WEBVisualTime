using WEBVisualTime.Servicios.Insudb.DTOs.TABLE183;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE183Controller : CrudApiController<TABLE183Dto, CreateTABLE183Dto, UpdateTABLE183Dto, int>
{
    public TABLE183Controller(ITABLE183Service service) : base(service, dto => dto.NCARD_TYPE) { }
}
