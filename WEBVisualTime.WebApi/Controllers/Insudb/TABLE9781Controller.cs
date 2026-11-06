using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9781;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9781Controller : CrudApiController<TABLE9781Dto, CreateTABLE9781Dto, UpdateTABLE9781Dto, int>
{
    public TABLE9781Controller(ITABLE9781Service service) : base(service, dto => dto.NSYSTEM) { }
}
