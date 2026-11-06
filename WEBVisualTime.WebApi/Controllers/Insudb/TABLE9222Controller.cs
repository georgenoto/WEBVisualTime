using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9222;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9222Controller : CrudApiController<TABLE9222Dto, CreateTABLE9222Dto, UpdateTABLE9222Dto, int>
{
    public TABLE9222Controller(ITABLE9222Service service) : base(service, dto => dto.NBENEFCATEG) { }
}
