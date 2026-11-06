using WEBVisualTime.Servicios.Insudb.DTOs.TABLE260;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE260Controller : CrudApiController<TABLE260Dto, CreateTABLE260Dto, UpdateTABLE260Dto, long>
{
    public TABLE260Controller(ITABLE260Service service) : base(service, dto => dto.NCODIGINT) { }
}
