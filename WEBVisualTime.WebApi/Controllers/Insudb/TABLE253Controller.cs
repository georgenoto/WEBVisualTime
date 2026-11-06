using WEBVisualTime.Servicios.Insudb.DTOs.TABLE253;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE253Controller : CrudApiController<TABLE253Dto, CreateTABLE253Dto, UpdateTABLE253Dto, int>
{
    public TABLE253Controller(ITABLE253Service service) : base(service, dto => dto.NSTAT_DRAFT) { }
}
