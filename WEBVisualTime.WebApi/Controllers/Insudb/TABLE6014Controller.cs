using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6014Controller : CrudApiController<TABLE6014Dto, CreateTABLE6014Dto, UpdateTABLE6014Dto, int>
{
    public TABLE6014Controller(ITABLE6014Service service) : base(service, dto => dto.NSEVERITY) { }
}
