using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9261;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9261Controller : CrudApiController<TABLE9261Dto, CreateTABLE9261Dto, UpdateTABLE9261Dto, int>
{
    public TABLE9261Controller(ITABLE9261Service service) : base(service, dto => dto.NORD_PROCEDURE) { }
}
