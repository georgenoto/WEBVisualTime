using WEBVisualTime.Servicios.Insudb.DTOs.TABLE72;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE72Controller : CrudApiController<TABLE72Dto, CreateTABLE72Dto, UpdateTABLE72Dto, int>
{
    public TABLE72Controller(ITABLE72Service service) : base(service, dto => dto.NREQEXC) { }
}
