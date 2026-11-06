using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5606;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5606Controller : CrudApiController<TABLE5606Dto, CreateTABLE5606Dto, UpdateTABLE5606Dto, int>
{
    public TABLE5606Controller(ITABLE5606Service service) : base(service, dto => dto.NFACTOR) { }
}
