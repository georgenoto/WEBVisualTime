using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5705;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5705Controller : CrudApiController<TABLE5705Dto, CreateTABLE5705Dto, UpdateTABLE5705Dto, int>
{
    public TABLE5705Controller(ITABLE5705Service service) : base(service, dto => dto.NSYSTEM) { }
}
