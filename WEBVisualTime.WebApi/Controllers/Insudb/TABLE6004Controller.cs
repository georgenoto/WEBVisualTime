using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6004Controller : CrudApiController<TABLE6004Dto, CreateTABLE6004Dto, UpdateTABLE6004Dto, int>
{
    public TABLE6004Controller(ITABLE6004Service service) : base(service, dto => dto.NSWIMPOOL) { }
}
