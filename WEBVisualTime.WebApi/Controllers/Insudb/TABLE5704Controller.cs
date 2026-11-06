using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5704;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5704Controller : CrudApiController<TABLE5704Dto, CreateTABLE5704Dto, UpdateTABLE5704Dto, int>
{
    public TABLE5704Controller(ITABLE5704Service service) : base(service, dto => dto.NOPERATOR) { }
}
