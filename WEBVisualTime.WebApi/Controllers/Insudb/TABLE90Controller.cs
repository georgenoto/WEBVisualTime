using WEBVisualTime.Servicios.Insudb.DTOs.TABLE90;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE90Controller : CrudApiController<TABLE90Dto, CreateTABLE90Dto, UpdateTABLE90Dto, string>
{
    public TABLE90Controller(ITABLE90Service service) : base(service, dto => dto.SCUMREINT) { }
}
