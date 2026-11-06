using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE271Controller : CrudApiController<TABLE271Dto, CreateTABLE271Dto, UpdateTABLE271Dto, int>
{
    public TABLE271Controller(ITABLE271Service service) : base(service, dto => dto.NEXC_CODE) { }
}
