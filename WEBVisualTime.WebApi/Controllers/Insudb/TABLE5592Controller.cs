using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5592;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5592Controller : CrudApiController<TABLE5592Dto, CreateTABLE5592Dto, UpdateTABLE5592Dto, int>
{
    public TABLE5592Controller(ITABLE5592Service service) : base(service, dto => dto.NTYPENAME) { }
}
