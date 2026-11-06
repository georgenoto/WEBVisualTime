using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9262;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9262Controller : CrudApiController<TABLE9262Dto, CreateTABLE9262Dto, UpdateTABLE9262Dto, int>
{
    public TABLE9262Controller(ITABLE9262Service service) : base(service, dto => dto.NCLAIM_ENTITY) { }
}
