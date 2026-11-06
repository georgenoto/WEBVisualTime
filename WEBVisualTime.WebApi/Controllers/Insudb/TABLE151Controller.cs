using WEBVisualTime.Servicios.Insudb.DTOs.TABLE151;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE151Controller : CrudApiController<TABLE151Dto, CreateTABLE151Dto, UpdateTABLE151Dto, int>
{
    public TABLE151Controller(ITABLE151Service service) : base(service, dto => dto.NCODE_SUS) { }
}
