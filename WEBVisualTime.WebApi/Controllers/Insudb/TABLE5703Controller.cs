using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5703;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5703Controller : CrudApiController<TABLE5703Dto, CreateTABLE5703Dto, UpdateTABLE5703Dto, int>
{
    public TABLE5703Controller(ITABLE5703Service service) : base(service, dto => dto.NOBJTYPE) { }
}
