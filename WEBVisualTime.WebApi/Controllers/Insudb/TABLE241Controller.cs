using WEBVisualTime.Servicios.Insudb.DTOs.TABLE241;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE241Controller : CrudApiController<TABLE241Dto, CreateTABLE241Dto, UpdateTABLE241Dto, int>
{
    public TABLE241Controller(ITABLE241Service service) : base(service, dto => dto.NRISKCLASS) { }
}
