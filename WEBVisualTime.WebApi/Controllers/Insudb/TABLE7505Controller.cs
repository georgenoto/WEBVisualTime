using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7505Controller : CrudApiController<TABLE7505Dto, CreateTABLE7505Dto, UpdateTABLE7505Dto, string>
{
    public TABLE7505Controller(ITABLE7505Service service) : base(service, dto => dto.SNULLACTION) { }
}
