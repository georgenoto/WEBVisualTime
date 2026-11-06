using WEBVisualTime.Servicios.Insudb.DTOs.TABLE560;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE560Controller : CrudApiController<TABLE560Dto, CreateTABLE560Dto, UpdateTABLE560Dto, int>
{
    public TABLE560Controller(ITABLE560Service service) : base(service, dto => dto.NORDCLASS) { }
}
