using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6002Controller : CrudApiController<TABLE6002Dto, CreateTABLE6002Dto, UpdateTABLE6002Dto, int>
{
    public TABLE6002Controller(ITABLE6002Service service) : base(service, dto => dto.NALT_HEATING) { }
}
