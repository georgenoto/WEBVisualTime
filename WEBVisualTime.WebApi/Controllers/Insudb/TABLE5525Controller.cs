using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5525;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5525Controller : CrudApiController<TABLE5525Dto, CreateTABLE5525Dto, UpdateTABLE5525Dto, int>
{
    public TABLE5525Controller(ITABLE5525Service service) : base(service, dto => dto.NTYPEMOVE) { }
}
