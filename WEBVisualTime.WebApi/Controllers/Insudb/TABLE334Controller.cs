using WEBVisualTime.Servicios.Insudb.DTOs.TABLE334;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE334Controller : CrudApiController<TABLE334Dto, CreateTABLE334Dto, UpdateTABLE334Dto, int>
{
    public TABLE334Controller(ITABLE334Service service) : base(service, dto => dto.NSTATUS) { }
}
