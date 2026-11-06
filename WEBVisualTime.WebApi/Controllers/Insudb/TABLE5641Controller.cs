using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5641;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5641Controller : CrudApiController<TABLE5641Dto, CreateTABLE5641Dto, UpdateTABLE5641Dto, int>
{
    public TABLE5641Controller(ITABLE5641Service service) : base(service, dto => dto.NINTENTION) { }
}
