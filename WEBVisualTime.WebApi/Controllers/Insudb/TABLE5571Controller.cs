using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5571;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5571Controller : CrudApiController<TABLE5571Dto, CreateTABLE5571Dto, UpdateTABLE5571Dto, int>
{
    public TABLE5571Controller(ITABLE5571Service service) : base(service, dto => dto.NSEARCH) { }
}
