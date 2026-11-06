using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9002Controller : CrudApiController<TABLE9002Dto, CreateTABLE9002Dto, UpdateTABLE9002Dto, int>
{
    public TABLE9002Controller(ITABLE9002Service service) : base(service, dto => dto.NMATERIA) { }
}
