using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9301;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9301Controller : CrudApiController<TABLE9301Dto, CreateTABLE9301Dto, UpdateTABLE9301Dto, int>
{
    public TABLE9301Controller(ITABLE9301Service service) : base(service, dto => dto.NPROMISSORYSTAT) { }
}
