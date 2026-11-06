using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5708;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5708Controller : CrudApiController<TABLE5708Dto, CreateTABLE5708Dto, UpdateTABLE5708Dto, long>
{
    public TABLE5708Controller(ITABLE5708Service service) : base(service, dto => dto.NTYPE_MOVE) { }
}
