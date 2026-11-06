using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8090;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8090Controller : CrudApiController<TABLE8090Dto, CreateTABLE8090Dto, UpdateTABLE8090Dto, int>
{
    public TABLE8090Controller(ITABLE8090Service service) : base(service, dto => dto.NSERIES) { }
}
