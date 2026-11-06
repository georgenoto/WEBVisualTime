using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5523;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5523Controller : CrudApiController<TABLE5523Dto, CreateTABLE5523Dto, UpdateTABLE5523Dto, int>
{
    public TABLE5523Controller(ITABLE5523Service service) : base(service, dto => dto.NHEALTH_ORG) { }
}
