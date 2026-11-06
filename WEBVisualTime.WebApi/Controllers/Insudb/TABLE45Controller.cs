using WEBVisualTime.Servicios.Insudb.DTOs.TABLE45;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE45Controller : CrudApiController<TABLE45Dto, CreateTABLE45Dto, UpdateTABLE45Dto, string>
{
    public TABLE45Controller(ITABLE45Service service) : base(service, dto => dto.SHOLDER) { }
}
