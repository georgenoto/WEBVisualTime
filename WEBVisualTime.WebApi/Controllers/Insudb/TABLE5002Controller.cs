using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5002Controller : CrudApiController<TABLE5002Dto, CreateTABLE5002Dto, UpdateTABLE5002Dto, int>
{
    public TABLE5002Controller(ITABLE5002Service service) : base(service, dto => dto.NWAY_PAY) { }
}
