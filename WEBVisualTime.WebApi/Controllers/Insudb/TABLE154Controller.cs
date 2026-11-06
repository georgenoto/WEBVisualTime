using WEBVisualTime.Servicios.Insudb.DTOs.TABLE154;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE154Controller : CrudApiController<TABLE154Dto, CreateTABLE154Dto, UpdateTABLE154Dto, string>
{
    public TABLE154Controller(ITABLE154Service service) : base(service, dto => dto.SREVALAPL) { }
}
