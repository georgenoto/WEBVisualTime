using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7220Controller : CrudApiController<TABLE7220Dto, CreateTABLE7220Dto, UpdateTABLE7220Dto, int>
{
    public TABLE7220Controller(ITABLE7220Service service) : base(service, dto => dto.NSECTION) { }
}
