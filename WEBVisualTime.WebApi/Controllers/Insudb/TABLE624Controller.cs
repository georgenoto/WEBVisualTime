using WEBVisualTime.Servicios.Insudb.DTOs.TABLE624;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE624Controller : CrudApiController<TABLE624Dto, CreateTABLE624Dto, UpdateTABLE624Dto, int>
{
    public TABLE624Controller(ITABLE624Service service) : base(service, dto => dto.NSTATLETTER) { }
}
