using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6059Controller : CrudApiController<TABLE6059Dto, CreateTABLE6059Dto, UpdateTABLE6059Dto, int>
{
    public TABLE6059Controller(ITABLE6059Service service) : base(service, dto => dto.NTYPE_AMEND) { }
}
