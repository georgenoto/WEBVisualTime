using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7206;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7206Controller : CrudApiController<TABLE7206Dto, CreateTABLE7206Dto, UpdateTABLE7206Dto, int>
{
    public TABLE7206Controller(ITABLE7206Service service) : base(service, dto => dto.NINSURTYPE) { }
}
