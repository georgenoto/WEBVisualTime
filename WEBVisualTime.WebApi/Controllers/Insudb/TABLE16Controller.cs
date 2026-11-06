using WEBVisualTime.Servicios.Insudb.DTOs.TABLE16;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE16Controller : CrudApiController<TABLE16Dto, CreateTABLE16Dto, UpdateTABLE16Dto, long>
{
    public TABLE16Controller(ITABLE16Service service) : base(service, dto => dto.NSPECIALITY) { }
}
