using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7042;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7042Controller : CrudApiController<TABLE7042Dto, CreateTABLE7042Dto, UpdateTABLE7042Dto, int>
{
    public TABLE7042Controller(ITABLE7042Service service) : base(service, dto => dto.NVEHBRAND) { }
}
