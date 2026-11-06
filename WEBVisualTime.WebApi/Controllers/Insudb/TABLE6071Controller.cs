using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6071;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6071Controller : CrudApiController<TABLE6071Dto, CreateTABLE6071Dto, UpdateTABLE6071Dto, int>
{
    public TABLE6071Controller(ITABLE6071Service service) : base(service, dto => dto.NTYPE_ACC) { }
}
