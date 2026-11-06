using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8605;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8605Controller : CrudApiController<TABLE8605Dto, CreateTABLE8605Dto, UpdateTABLE8605Dto, string>
{
    public TABLE8605Controller(ITABLE8605Service service) : base(service, dto => dto.SCARECLASS) { }
}
