using WEBVisualTime.Servicios.Insudb.DTOs.TABLE48;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE48Controller : CrudApiController<TABLE48Dto, CreateTABLE48Dto, UpdateTABLE48Dto, int>
{
    public TABLE48Controller(ITABLE48Service service) : base(service, dto => dto.NTYPE_RESERVE) { }
}
