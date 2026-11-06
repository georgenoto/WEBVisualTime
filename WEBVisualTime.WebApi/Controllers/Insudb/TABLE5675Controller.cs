using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5675;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5675Controller : CrudApiController<TABLE5675Dto, CreateTABLE5675Dto, UpdateTABLE5675Dto, int>
{
    public TABLE5675Controller(ITABLE5675Service service) : base(service, dto => dto.NINFTYPE) { }
}
