using WEBVisualTime.Servicios.Insudb.DTOs.TABLE640;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE640Controller : CrudApiController<TABLE640Dto, CreateTABLE640Dto, UpdateTABLE640Dto, int>
{
    public TABLE640Controller(ITABLE640Service service) : base(service, dto => dto.NECON_AREA) { }
}
