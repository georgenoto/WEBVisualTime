using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6786;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6786Controller : CrudApiController<TABLE6786Dto, CreateTABLE6786Dto, UpdateTABLE6786Dto, int>
{
    public TABLE6786Controller(ITABLE6786Service service) : base(service, dto => dto.NDEFTYPE) { }
}
