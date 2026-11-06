using WEBVisualTime.Servicios.Insudb.DTOs.TABLE93;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE93Controller : CrudApiController<TABLE93Dto, CreateTABLE93Dto, UpdateTABLE93Dto, int>
{
    public TABLE93Controller(ITABLE93Service service) : base(service, dto => dto.NTIME_UNIT) { }
}
