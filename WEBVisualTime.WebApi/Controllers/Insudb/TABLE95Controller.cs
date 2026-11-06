using WEBVisualTime.Servicios.Insudb.DTOs.TABLE95;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE95Controller : CrudApiController<TABLE95Dto, CreateTABLE95Dto, UpdateTABLE95Dto, int>
{
    public TABLE95Controller(ITABLE95Service service) : base(service, dto => dto.NNULLCODE) { }
}
