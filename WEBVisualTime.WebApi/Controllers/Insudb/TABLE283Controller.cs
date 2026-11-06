using WEBVisualTime.Servicios.Insudb.DTOs.TABLE283;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE283Controller : CrudApiController<TABLE283Dto, CreateTABLE283Dto, UpdateTABLE283Dto, int>
{
    public TABLE283Controller(ITABLE283Service service) : base(service, dto => dto.NPOSITION) { }
}
