using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9246;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9246Controller : CrudApiController<TABLE9246Dto, CreateTABLE9246Dto, UpdateTABLE9246Dto, int>
{
    public TABLE9246Controller(ITABLE9246Service service) : base(service, dto => dto.NCOD_REJECT) { }
}
