using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE36Controller : CrudApiController<TABLE36Dto, CreateTABLE36Dto, UpdateTABLE36Dto, int>
{
    public TABLE36Controller(ITABLE36Service service) : base(service, dto => dto.NPAYFREQ) { }
}
