using WEBVisualTime.Servicios.Insudb.DTOs.TABLE282;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE282Controller : CrudApiController<TABLE282Dto, CreateTABLE282Dto, UpdateTABLE282Dto, int>
{
    public TABLE282Controller(ITABLE282Service service) : base(service, dto => dto.NSTATPRINT) { }
}
