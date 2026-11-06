using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5505Controller : CrudApiController<TABLE5505Dto, CreateTABLE5505Dto, UpdateTABLE5505Dto, int>
{
    public TABLE5505Controller(ITABLE5505Service service) : base(service, dto => dto.NDISABILITY) { }
}
