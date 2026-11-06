using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6034;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6034Controller : CrudApiController<TABLE6034Dto, CreateTABLE6034Dto, UpdateTABLE6034Dto, int>
{
    public TABLE6034Controller(ITABLE6034Service service) : base(service, dto => dto.NMODALITYSUMINS) { }
}
