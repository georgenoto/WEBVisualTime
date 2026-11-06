using WEBVisualTime.Servicios.Insudb.DTOs.TABLE527;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE527Controller : CrudApiController<TABLE527Dto, CreateTABLE527Dto, UpdateTABLE527Dto, int>
{
    public TABLE527Controller(ITABLE527Service service) : base(service, dto => dto.NSINIES_TYPE) { }
}
