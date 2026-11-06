using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5503;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5503Controller : CrudApiController<TABLE5503Dto, CreateTABLE5503Dto, UpdateTABLE5503Dto, long>
{
    public TABLE5503Controller(ITABLE5503Service service) : base(service, dto => dto.NAREA) { }
}
