using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE25Controller : CrudApiController<TABLE25Dto, CreateTABLE25Dto, UpdateTABLE25Dto, string>
{
    public TABLE25Controller(ITABLE25Service service) : base(service, dto => dto.STIMEREN) { }
}
