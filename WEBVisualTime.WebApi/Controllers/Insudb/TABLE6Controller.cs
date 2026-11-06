using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6Controller : CrudApiController<TABLE6Dto, CreateTABLE6Dto, UpdateTABLE6Dto, int>
{
    public TABLE6Controller(ITABLE6Service service) : base(service, dto => dto.NTYPE_TRAN) { }
}
