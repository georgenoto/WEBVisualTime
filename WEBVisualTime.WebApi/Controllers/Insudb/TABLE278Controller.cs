using WEBVisualTime.Servicios.Insudb.DTOs.TABLE278;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE278Controller : CrudApiController<TABLE278Dto, CreateTABLE278Dto, UpdateTABLE278Dto, int>
{
    public TABLE278Controller(ITABLE278Service service) : base(service, dto => dto.NSTAT_CONTR) { }
}
