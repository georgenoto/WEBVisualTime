using WEBVisualTime.Servicios.Insudb.DTOs.TABLE77;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE77Controller : CrudApiController<TABLE77Dto, CreateTABLE77Dto, UpdateTABLE77Dto, int>
{
    public TABLE77Controller(ITABLE77Service service) : base(service, dto => dto.NCAUSE_AMEN) { }
}
