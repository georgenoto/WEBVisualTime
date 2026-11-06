using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5567;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5567Controller : CrudApiController<TABLE5567Dto, CreateTABLE5567Dto, UpdateTABLE5567Dto, int>
{
    public TABLE5567Controller(ITABLE5567Service service) : base(service, dto => dto.NTYPMOV_COMM) { }
}
