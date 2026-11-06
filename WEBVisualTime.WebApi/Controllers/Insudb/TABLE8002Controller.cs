using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8002Controller : CrudApiController<TABLE8002Dto, CreateTABLE8002Dto, UpdateTABLE8002Dto, int>
{
    public TABLE8002Controller(ITABLE8002Service service) : base(service, dto => dto.NVALDATE_ISSUE) { }
}
