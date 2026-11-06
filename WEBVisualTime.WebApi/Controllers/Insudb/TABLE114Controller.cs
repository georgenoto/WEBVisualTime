using WEBVisualTime.Servicios.Insudb.DTOs.TABLE114;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE114Controller : CrudApiController<TABLE114Dto, CreateTABLE114Dto, UpdateTABLE114Dto, long>
{
    public TABLE114Controller(ITABLE114Service service) : base(service, dto => dto.NSURRFREQ) { }
}
