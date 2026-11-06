using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7002Controller : CrudApiController<TABLE7002Dto, CreateTABLE7002Dto, UpdateTABLE7002Dto, int>
{
    public TABLE7002Controller(ITABLE7002Service service) : base(service, dto => dto.NRESPONSECODE) { }
}
