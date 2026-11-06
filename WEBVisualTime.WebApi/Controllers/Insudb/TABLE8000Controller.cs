using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8000Controller : CrudApiController<TABLE8000Dto, CreateTABLE8000Dto, UpdateTABLE8000Dto, int>
{
    public TABLE8000Controller(ITABLE8000Service service) : base(service, dto => dto.NTYPEDOC) { }
}
