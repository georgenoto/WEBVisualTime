using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5549;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5549Controller : CrudApiController<TABLE5549Dto, CreateTABLE5549Dto, UpdateTABLE5549Dto, int>
{
    public TABLE5549Controller(ITABLE5549Service service) : base(service, dto => dto.NINCAPACITY) { }
}
