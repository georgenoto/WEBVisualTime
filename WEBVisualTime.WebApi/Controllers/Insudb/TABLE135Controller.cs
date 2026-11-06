using WEBVisualTime.Servicios.Insudb.DTOs.TABLE135;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE135Controller : CrudApiController<TABLE135Dto, CreateTABLE135Dto, UpdateTABLE135Dto, string>
{
    public TABLE135Controller(ITABLE135Service service) : base(service, dto => dto.SSTACLAIM) { }
}
