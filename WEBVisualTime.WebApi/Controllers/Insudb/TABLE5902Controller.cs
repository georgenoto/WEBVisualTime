using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5902;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5902Controller : CrudApiController<TABLE5902Dto, CreateTABLE5902Dto, UpdateTABLE5902Dto, int>
{
    public TABLE5902Controller(ITABLE5902Service service) : base(service, dto => dto.NTYPE_MAIL) { }
}
