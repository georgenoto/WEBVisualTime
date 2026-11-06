using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6003Controller : CrudApiController<TABLE6003Dto, CreateTABLE6003Dto, UpdateTABLE6003Dto, int>
{
    public TABLE6003Controller(ITABLE6003Service service) : base(service, dto => dto.NFOUNDTYPE) { }
}
