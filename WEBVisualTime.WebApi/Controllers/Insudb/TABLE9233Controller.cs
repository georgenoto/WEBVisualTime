using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9233;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9233Controller : CrudApiController<TABLE9233Dto, CreateTABLE9233Dto, UpdateTABLE9233Dto, string>
{
    public TABLE9233Controller(ITABLE9233Service service) : base(service, dto => dto.STYPCALC_FLATPREM) { }
}
