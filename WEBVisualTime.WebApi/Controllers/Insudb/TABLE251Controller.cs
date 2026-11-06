using WEBVisualTime.Servicios.Insudb.DTOs.TABLE251;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE251Controller : CrudApiController<TABLE251Dto, CreateTABLE251Dto, UpdateTABLE251Dto, long>
{
    public TABLE251Controller(ITABLE251Service service) : base(service, dto => dto.NCODIGINT) { }
}
