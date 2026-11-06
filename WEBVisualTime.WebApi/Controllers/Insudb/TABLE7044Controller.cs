using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7044;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7044Controller : CrudApiController<TABLE7044Dto, CreateTABLE7044Dto, UpdateTABLE7044Dto, int>
{
    public TABLE7044Controller(ITABLE7044Service service) : base(service, dto => dto.NACTIVITYCAT) { }
}
