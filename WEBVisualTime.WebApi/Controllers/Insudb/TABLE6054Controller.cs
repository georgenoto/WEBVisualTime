using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6054;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6054Controller : CrudApiController<TABLE6054Dto, CreateTABLE6054Dto, UpdateTABLE6054Dto, int>
{
    public TABLE6054Controller(ITABLE6054Service service) : base(service, dto => dto.NSECTION) { }
}
