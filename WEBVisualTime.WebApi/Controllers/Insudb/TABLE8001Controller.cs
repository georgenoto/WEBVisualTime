using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8001Controller : CrudApiController<TABLE8001Dto, CreateTABLE8001Dto, UpdateTABLE8001Dto, int>
{
    public TABLE8001Controller(ITABLE8001Service service) : base(service, dto => dto.NGUARSAV_STAT) { }
}
