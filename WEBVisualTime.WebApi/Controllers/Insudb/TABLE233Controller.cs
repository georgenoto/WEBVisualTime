using WEBVisualTime.Servicios.Insudb.DTOs.TABLE233;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE233Controller : CrudApiController<TABLE233Dto, CreateTABLE233Dto, UpdateTABLE233Dto, int>
{
    public TABLE233Controller(ITABLE233Service service) : base(service, dto => dto.NCONSTCAT) { }
}
