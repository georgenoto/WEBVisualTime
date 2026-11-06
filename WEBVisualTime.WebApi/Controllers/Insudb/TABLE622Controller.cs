using WEBVisualTime.Servicios.Insudb.DTOs.TABLE622;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE622Controller : CrudApiController<TABLE622Dto, CreateTABLE622Dto, UpdateTABLE622Dto, int>
{
    public TABLE622Controller(ITABLE622Service service) : base(service, dto => dto.NPARAMETERS) { }
}
