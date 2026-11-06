using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9258Controller : CrudApiController<TABLE9258Dto, CreateTABLE9258Dto, UpdateTABLE9258Dto, int>
{
    public TABLE9258Controller(ITABLE9258Service service) : base(service, dto => dto.NSERV_ESTRUCT) { }
}
