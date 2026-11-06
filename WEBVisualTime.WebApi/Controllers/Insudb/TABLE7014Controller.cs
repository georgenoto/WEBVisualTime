using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7014Controller : CrudApiController<TABLE7014Dto, CreateTABLE7014Dto, UpdateTABLE7014Dto, long>
{
    public TABLE7014Controller(ITABLE7014Service service) : base(service, dto => dto.NTYPE_INF) { }
}
