using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE193Controller : CrudApiController<TABLE193Dto, CreateTABLE193Dto, UpdateTABLE193Dto, string>
{
    public TABLE193Controller(ITABLE193Service service) : base(service, dto => dto.SREQUEST_TY) { }
}
