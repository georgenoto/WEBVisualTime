using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6005Controller : CrudApiController<TABLE6005Dto, CreateTABLE6005Dto, UpdateTABLE6005Dto, int>
{
    public TABLE6005Controller(ITABLE6005Service service) : base(service, dto => dto.NOWNERSHIP) { }
}
