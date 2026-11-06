using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6031Controller : CrudApiController<TABLE6031Dto, CreateTABLE6031Dto, UpdateTABLE6031Dto, int>
{
    public TABLE6031Controller(ITABLE6031Service service) : base(service, dto => dto.NTRANSPTYPE) { }
}
