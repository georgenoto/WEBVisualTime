using WEBVisualTime.Servicios.Insudb.DTOs.TABLE252;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE252Controller : CrudApiController<TABLE252Dto, CreateTABLE252Dto, UpdateTABLE252Dto, long>
{
    public TABLE252Controller(ITABLE252Service service) : base(service, dto => dto.NCODIGINT) { }
}
