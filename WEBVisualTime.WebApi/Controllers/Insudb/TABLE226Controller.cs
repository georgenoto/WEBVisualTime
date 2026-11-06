using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE226Controller : CrudApiController<TABLE226Dto, CreateTABLE226Dto, UpdateTABLE226Dto, int>
{
    public TABLE226Controller(ITABLE226Service service) : base(service, dto => dto.NVEHTYPE) { }
}
