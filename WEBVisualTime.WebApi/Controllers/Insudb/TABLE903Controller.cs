using WEBVisualTime.Servicios.Insudb.DTOs.TABLE903;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE903Controller : CrudApiController<TABLE903Dto, CreateTABLE903Dto, UpdateTABLE903Dto, int>
{
    public TABLE903Controller(ITABLE903Service service) : base(service, dto => dto.NSTAINFCASE) { }
}
