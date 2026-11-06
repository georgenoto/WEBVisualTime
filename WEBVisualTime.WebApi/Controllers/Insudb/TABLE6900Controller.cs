using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6900;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6900Controller : CrudApiController<TABLE6900Dto, CreateTABLE6900Dto, UpdateTABLE6900Dto, int>
{
    public TABLE6900Controller(ITABLE6900Service service) : base(service, dto => dto.NINSMODALITY) { }
}
