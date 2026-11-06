using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5709;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5709Controller : CrudApiController<TABLE5709Dto, CreateTABLE5709Dto, UpdateTABLE5709Dto, long>
{
    public TABLE5709Controller(ITABLE5709Service service) : base(service, dto => dto.NTYPE) { }
}
