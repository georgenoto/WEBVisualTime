using WEBVisualTime.Servicios.Insudb.DTOs.TABLE511;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE511Controller : CrudApiController<TABLE511Dto, CreateTABLE511Dto, UpdateTABLE511Dto, string>
{
    public TABLE511Controller(ITABLE511Service service) : base(service, dto => dto.SIND_TYPE) { }
}
