using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8204Controller : CrudApiController<TABLE8204Dto, CreateTABLE8204Dto, UpdateTABLE8204Dto, string>
{
    public TABLE8204Controller(ITABLE8204Service service) : base(service, dto => dto.STYP_CONDI) { }
}
