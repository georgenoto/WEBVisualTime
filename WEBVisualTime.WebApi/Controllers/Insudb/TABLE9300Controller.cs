using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9300Controller : CrudApiController<TABLE9300Dto, CreateTABLE9300Dto, UpdateTABLE9300Dto, int>
{
    public TABLE9300Controller(ITABLE9300Service service) : base(service, dto => dto.NPROMISSORYNOTE) { }
}
