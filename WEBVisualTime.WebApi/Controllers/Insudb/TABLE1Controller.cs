using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1Controller : CrudApiController<TABLE1Dto, CreateTABLE1Dto, UpdateTABLE1Dto, long>
{
    public TABLE1Controller(ITABLE1Service service) : base(service, dto => dto.NCODIGINT) { }
}
