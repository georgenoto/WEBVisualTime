using WEBVisualTime.Servicios.Insudb.DTOs.TABLE18;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE18Controller : CrudApiController<TABLE18Dto, CreateTABLE18Dto, UpdateTABLE18Dto, string>
{
    public TABLE18Controller(ITABLE18Service service) : base(service, dto => dto.SSEXCLIEN) { }
}
