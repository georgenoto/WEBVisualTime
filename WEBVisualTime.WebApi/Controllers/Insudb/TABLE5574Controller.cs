using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5574;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5574Controller : CrudApiController<TABLE5574Dto, CreateTABLE5574Dto, UpdateTABLE5574Dto, int>
{
    public TABLE5574Controller(ITABLE5574Service service) : base(service, dto => dto.NSENDADDR) { }
}
