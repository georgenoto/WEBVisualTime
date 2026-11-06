using WEBVisualTime.Servicios.Insudb.DTOs.TABLE300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE300Controller : CrudApiController<TABLE300Dto, CreateTABLE300Dto, UpdateTABLE300Dto, long>
{
    public TABLE300Controller(ITABLE300Service service) : base(service, dto => dto.NCODIGINT) { }
}
