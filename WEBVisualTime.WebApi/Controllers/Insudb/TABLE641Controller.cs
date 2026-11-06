using WEBVisualTime.Servicios.Insudb.DTOs.TABLE641;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE641Controller : CrudApiController<TABLE641Dto, CreateTABLE641Dto, UpdateTABLE641Dto, long>
{
    public TABLE641Controller(ITABLE641Service service) : base(service, dto => dto.NCODIGINT) { }
}
