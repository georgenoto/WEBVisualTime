using WEBVisualTime.Servicios.Insudb.DTOs.TABLE694;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE694Controller : CrudApiController<TABLE694Dto, CreateTABLE694Dto, UpdateTABLE694Dto, int>
{
    public TABLE694Controller(ITABLE694Service service) : base(service, dto => dto.NINTCALC) { }
}
