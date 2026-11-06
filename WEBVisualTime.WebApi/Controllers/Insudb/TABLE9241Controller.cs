using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9241;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9241Controller : CrudApiController<TABLE9241Dto, CreateTABLE9241Dto, UpdateTABLE9241Dto, int>
{
    public TABLE9241Controller(ITABLE9241Service service) : base(service, dto => dto.NSTATUS_ORDER) { }
}
