using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8100Controller : CrudApiController<TABLE8100Dto, CreateTABLE8100Dto, UpdateTABLE8100Dto, int>
{
    public TABLE8100Controller(ITABLE8100Service service) : base(service, dto => dto.NTYPE_CALC) { }
}
