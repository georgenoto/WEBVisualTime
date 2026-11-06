using WEBVisualTime.Servicios.Insudb.DTOs.TABLE20;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE20Controller : CrudApiController<TABLE20Dto, CreateTABLE20Dto, UpdateTABLE20Dto, long>
{
    public TABLE20Controller(ITABLE20Service service) : base(service, dto => dto.NCODIGINT) { }
}
