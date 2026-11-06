using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5625;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5625Controller : CrudApiController<TABLE5625Dto, CreateTABLE5625Dto, UpdateTABLE5625Dto, int>
{
    public TABLE5625Controller(ITABLE5625Service service) : base(service, dto => dto.NTYPE) { }
}
