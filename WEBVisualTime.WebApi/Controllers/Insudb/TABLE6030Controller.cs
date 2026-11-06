using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6030Controller : CrudApiController<TABLE6030Dto, CreateTABLE6030Dto, UpdateTABLE6030Dto, int>
{
    public TABLE6030Controller(ITABLE6030Service service) : base(service, dto => dto.NTYPECALCULATE) { }
}
