using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8505Controller : CrudApiController<TABLE8505Dto, CreateTABLE8505Dto, UpdateTABLE8505Dto, int>
{
    public TABLE8505Controller(ITABLE8505Service service) : base(service, dto => dto.NTYPEPREMIUM) { }
}
