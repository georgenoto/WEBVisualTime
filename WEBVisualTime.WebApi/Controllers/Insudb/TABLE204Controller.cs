using WEBVisualTime.Servicios.Insudb.DTOs.TABLE204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE204Controller : CrudApiController<TABLE204Dto, CreateTABLE204Dto, UpdateTABLE204Dto, int>
{
    public TABLE204Controller(ITABLE204Service service) : base(service, dto => dto.NBLAME) { }
}
