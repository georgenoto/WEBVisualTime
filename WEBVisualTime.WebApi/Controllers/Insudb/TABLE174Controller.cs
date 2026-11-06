using WEBVisualTime.Servicios.Insudb.DTOs.TABLE174;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE174Controller : CrudApiController<TABLE174Dto, CreateTABLE174Dto, UpdateTABLE174Dto, int>
{
    public TABLE174Controller(ITABLE174Service service) : base(service, dto => dto.NCLASS_AP) { }
}
