using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6001Controller : CrudApiController<TABLE6001Dto, CreateTABLE6001Dto, UpdateTABLE6001Dto, int>
{
    public TABLE6001Controller(ITABLE6001Service service) : base(service, dto => dto.NAIRTYPE) { }
}
