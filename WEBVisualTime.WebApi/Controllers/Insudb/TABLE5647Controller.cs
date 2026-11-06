using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5647;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5647Controller : CrudApiController<TABLE5647Dto, CreateTABLE5647Dto, UpdateTABLE5647Dto, int>
{
    public TABLE5647Controller(ITABLE5647Service service) : base(service, dto => dto.NLIMIT_TYPE) { }
}
