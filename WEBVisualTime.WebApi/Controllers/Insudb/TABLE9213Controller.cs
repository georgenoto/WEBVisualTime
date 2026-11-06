using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9213;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9213Controller : CrudApiController<TABLE9213Dto, CreateTABLE9213Dto, UpdateTABLE9213Dto, int>
{
    public TABLE9213Controller(ITABLE9213Service service) : base(service, dto => dto.NPOSITION_CLI) { }
}
