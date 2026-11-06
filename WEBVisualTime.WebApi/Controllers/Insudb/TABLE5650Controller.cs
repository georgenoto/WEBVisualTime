using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5650;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5650Controller : CrudApiController<TABLE5650Dto, CreateTABLE5650Dto, UpdateTABLE5650Dto, int>
{
    public TABLE5650Controller(ITABLE5650Service service) : base(service, dto => dto.NCLASS_CONCEPT) { }
}
