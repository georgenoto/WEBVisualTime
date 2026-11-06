using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9003Controller : CrudApiController<TABLE9003Dto, CreateTABLE9003Dto, UpdateTABLE9003Dto, int>
{
    public TABLE9003Controller(ITABLE9003Service service) : base(service, dto => dto.NAJUSTTYPE) { }
}
