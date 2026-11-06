using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7504;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7504Controller : CrudApiController<TABLE7504Dto, CreateTABLE7504Dto, UpdateTABLE7504Dto, string>
{
    public TABLE7504Controller(ITABLE7504Service service) : base(service, dto => dto.STYP_COMISS) { }
}
