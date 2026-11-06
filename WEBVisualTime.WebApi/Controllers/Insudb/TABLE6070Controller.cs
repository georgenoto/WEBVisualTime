using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6070;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6070Controller : CrudApiController<TABLE6070Dto, CreateTABLE6070Dto, UpdateTABLE6070Dto, string>
{
    public TABLE6070Controller(ITABLE6070Service service) : base(service, dto => dto.STRATYPEI) { }
}
