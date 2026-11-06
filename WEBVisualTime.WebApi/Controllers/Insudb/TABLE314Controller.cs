using WEBVisualTime.Servicios.Insudb.DTOs.TABLE314;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE314Controller : CrudApiController<TABLE314Dto, CreateTABLE314Dto, UpdateTABLE314Dto, int>
{
    public TABLE314Controller(ITABLE314Service service) : base(service, dto => dto.NEXP_ROUTINE) { }
}
