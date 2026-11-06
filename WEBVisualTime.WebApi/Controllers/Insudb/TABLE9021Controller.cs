using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9021;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9021Controller : CrudApiController<TABLE9021Dto, CreateTABLE9021Dto, UpdateTABLE9021Dto, int>
{
    public TABLE9021Controller(ITABLE9021Service service) : base(service, dto => dto.NPROPAY) { }
}
