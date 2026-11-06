using WEBVisualTime.Servicios.Insudb.DTOs.TABLE224;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE224Controller : CrudApiController<TABLE224Dto, CreateTABLE224Dto, UpdateTABLE224Dto, long>
{
    public TABLE224Controller(ITABLE224Service service) : base(service, dto => dto.NAUTOZONE) { }
}
