using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1008Controller : CrudApiController<TABLE1008Dto, CreateTABLE1008Dto, UpdateTABLE1008Dto, int>
{
    public TABLE1008Controller(ITABLE1008Service service) : base(service, dto => dto.NVAL_ASSO) { }
}
