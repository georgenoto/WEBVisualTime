using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8300Controller : CrudApiController<TABLE8300Dto, CreateTABLE8300Dto, UpdateTABLE8300Dto, int>
{
    public TABLE8300Controller(ITABLE8300Service service) : base(service, dto => dto.NTYPE_RATEPROY) { }
}
