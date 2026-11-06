using WEBVisualTime.Servicios.Insudb.DTOs.TABLE950;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE950Controller : CrudApiController<TABLE950Dto, CreateTABLE950Dto, UpdateTABLE950Dto, long>
{
    public TABLE950Controller(ITABLE950Service service) : base(service, dto => dto.NTYP_PROFITWORKER) { }
}
