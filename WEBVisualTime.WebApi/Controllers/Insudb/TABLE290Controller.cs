using WEBVisualTime.Servicios.Insudb.DTOs.TABLE290;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE290Controller : CrudApiController<TABLE290Dto, CreateTABLE290Dto, UpdateTABLE290Dto, long>
{
    public TABLE290Controller(ITABLE290Service service) : base(service, dto => dto.SCODIGINT) { }
}
