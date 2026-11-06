using WEBVisualTime.Servicios.Insudb.DTOs.TABLE74;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE74Controller : CrudApiController<TABLE74Dto, CreateTABLE74Dto, UpdateTABLE74Dto, long>
{
    public TABLE74Controller(ITABLE74Service service) : base(service, dto => dto.NPAYINTER) { }
}
