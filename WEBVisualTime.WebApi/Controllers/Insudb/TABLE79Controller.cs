using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE79Controller : CrudApiController<TABLE79Dto, CreateTABLE79Dto, UpdateTABLE79Dto, string>
{
    public TABLE79Controller(ITABLE79Service service) : base(service, dto => dto.SCUMULTYP) { }
}
