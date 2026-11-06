using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6028Controller : CrudApiController<TABLE6028Dto, CreateTABLE6028Dto, UpdateTABLE6028Dto, int>
{
    public TABLE6028Controller(ITABLE6028Service service) : base(service, dto => dto.NGROUPVEH) { }
}
