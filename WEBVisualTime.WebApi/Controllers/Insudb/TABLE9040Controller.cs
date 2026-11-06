using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9040;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9040Controller : CrudApiController<TABLE9040Dto, CreateTABLE9040Dto, UpdateTABLE9040Dto, int>
{
    public TABLE9040Controller(ITABLE9040Service service) : base(service, dto => dto.NTYPE_SETTLE) { }
}
