using WEBVisualTime.Servicios.Insudb.DTOs.TABLE96;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE96Controller : CrudApiController<TABLE96Dto, CreateTABLE96Dto, UpdateTABLE96Dto, long>
{
    public TABLE96Controller(ITABLE96Service service) : base(service, dto => dto.NCODIGINT) { }
}
