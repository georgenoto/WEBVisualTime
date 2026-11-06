using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5743;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5743Controller : CrudApiController<TABLE5743Dto, CreateTABLE5743Dto, UpdateTABLE5743Dto, int>
{
    public TABLE5743Controller(ITABLE5743Service service) : base(service, dto => dto.NTYPE_AMEAPV) { }
}
