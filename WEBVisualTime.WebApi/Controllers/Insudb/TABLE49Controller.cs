using WEBVisualTime.Servicios.Insudb.DTOs.TABLE49;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE49Controller : CrudApiController<TABLE49Dto, CreateTABLE49Dto, UpdateTABLE49Dto, string>
{
    public TABLE49Controller(ITABLE49Service service) : base(service, dto => dto.SCOLREINT) { }
}
