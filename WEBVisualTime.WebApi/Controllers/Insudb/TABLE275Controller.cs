using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE275Controller : CrudApiController<TABLE275Dto, CreateTABLE275Dto, UpdateTABLE275Dto, int>
{
    public TABLE275Controller(ITABLE275Service service) : base(service, dto => dto.NSTAT_DOCREQ) { }
}
