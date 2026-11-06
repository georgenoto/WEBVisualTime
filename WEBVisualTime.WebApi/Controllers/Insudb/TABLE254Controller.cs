using WEBVisualTime.Servicios.Insudb.DTOs.TABLE254;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE254Controller : CrudApiController<TABLE254Dto, CreateTABLE254Dto, UpdateTABLE254Dto, long>
{
    public TABLE254Controller(ITABLE254Service service) : base(service, dto => dto.NCODIGINT) { }
}
