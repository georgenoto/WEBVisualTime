using WEBVisualTime.Servicios.Insudb.DTOs.TABLE173;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE173Controller : CrudApiController<TABLE173Dto, CreateTABLE173Dto, UpdateTABLE173Dto, int>
{
    public TABLE173Controller(ITABLE173Service service) : base(service, dto => dto.NTYPE_REIN) { }
}
