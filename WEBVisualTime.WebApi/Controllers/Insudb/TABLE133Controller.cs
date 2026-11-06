using WEBVisualTime.Servicios.Insudb.DTOs.TABLE133;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE133Controller : CrudApiController<TABLE133Dto, CreateTABLE133Dto, UpdateTABLE133Dto, int>
{
    public TABLE133Controller(ITABLE133Service service) : base(service, dto => dto.NUNACCODE) { }
}
