using WEBVisualTime.Servicios.Insudb.DTOs.TABLE333;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE333Controller : CrudApiController<TABLE333Dto, CreateTABLE333Dto, UpdateTABLE333Dto, int>
{
    public TABLE333Controller(ITABLE333Service service) : base(service, dto => dto.NTYPE_MOVE) { }
}
