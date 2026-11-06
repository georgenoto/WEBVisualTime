using WEBVisualTime.Servicios.Insudb.DTOs.TABLE80;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE80Controller : CrudApiController<TABLE80Dto, CreateTABLE80Dto, UpdateTABLE80Dto, string>
{
    public TABLE80Controller(ITABLE80Service service) : base(service, dto => dto.SLICENSE_TY) { }
}
