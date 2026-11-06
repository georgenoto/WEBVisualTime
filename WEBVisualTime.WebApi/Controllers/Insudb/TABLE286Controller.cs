using WEBVisualTime.Servicios.Insudb.DTOs.TABLE286;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE286Controller : CrudApiController<TABLE286Dto, CreateTABLE286Dto, UpdateTABLE286Dto, long>
{
    public TABLE286Controller(ITABLE286Service service) : base(service, dto => dto.NCODIGINT) { }
}
