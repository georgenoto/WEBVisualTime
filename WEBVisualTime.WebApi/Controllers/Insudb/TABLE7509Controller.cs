using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7509;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7509Controller : CrudApiController<TABLE7509Dto, CreateTABLE7509Dto, UpdateTABLE7509Dto, int>
{
    public TABLE7509Controller(ITABLE7509Service service) : base(service, dto => dto.NCODIGINT) { }
}
