using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5632;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5632Controller : CrudApiController<TABLE5632Dto, CreateTABLE5632Dto, UpdateTABLE5632Dto, string>
{
    public TABLE5632Controller(ITABLE5632Service service) : base(service, dto => dto.SCERTYPE) { }
}
