using WEBVisualTime.Servicios.Insudb.DTOs.TABLE403;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE403Controller : CrudApiController<TABLE403Dto, CreateTABLE403Dto, UpdateTABLE403Dto, long>
{
    public TABLE403Controller(ITABLE403Service service) : base(service, dto => dto.NCODIGINT) { }
}
