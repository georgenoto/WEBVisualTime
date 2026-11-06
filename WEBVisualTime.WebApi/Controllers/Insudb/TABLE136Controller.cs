using WEBVisualTime.Servicios.Insudb.DTOs.TABLE136;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE136Controller : CrudApiController<TABLE136Dto, CreateTABLE136Dto, UpdateTABLE136Dto, int>
{
    public TABLE136Controller(ITABLE136Service service) : base(service, dto => dto.NNULLCODE) { }
}
