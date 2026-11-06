using WEBVisualTime.Servicios.Insudb.DTOs.TABLE87;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE87Controller : CrudApiController<TABLE87Dto, CreateTABLE87Dto, UpdateTABLE87Dto, int>
{
    public TABLE87Controller(ITABLE87Service service) : base(service, dto => dto.NMODULES) { }
}
