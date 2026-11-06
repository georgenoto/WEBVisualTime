using WEBVisualTime.Servicios.Insudb.DTOs.TABLE46;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE46Controller : CrudApiController<TABLE46Dto, CreateTABLE46Dto, UpdateTABLE46Dto, string>
{
    public TABLE46Controller(ITABLE46Service service) : base(service, dto => dto.SREVALTYP) { }
}
