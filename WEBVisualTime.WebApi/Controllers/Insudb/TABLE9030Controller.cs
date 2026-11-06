using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9030Controller : CrudApiController<TABLE9030Dto, CreateTABLE9030Dto, UpdateTABLE9030Dto, int>
{
    public TABLE9030Controller(ITABLE9030Service service) : base(service, dto => dto.NDESRATING) { }
}
