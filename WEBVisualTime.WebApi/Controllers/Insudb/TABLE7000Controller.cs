using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7000Controller : CrudApiController<TABLE7000Dto, CreateTABLE7000Dto, UpdateTABLE7000Dto, int>
{
    public TABLE7000Controller(ITABLE7000Service service) : base(service, dto => dto.NTABLE) { }
}
