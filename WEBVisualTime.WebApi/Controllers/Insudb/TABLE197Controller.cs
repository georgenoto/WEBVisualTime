using WEBVisualTime.Servicios.Insudb.DTOs.TABLE197;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE197Controller : CrudApiController<TABLE197Dto, CreateTABLE197Dto, UpdateTABLE197Dto, int>
{
    public TABLE197Controller(ITABLE197Service service) : base(service, dto => dto.NAVAIL_TYPE) { }
}
