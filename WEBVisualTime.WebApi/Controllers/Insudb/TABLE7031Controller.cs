using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7031Controller : CrudApiController<TABLE7031Dto, CreateTABLE7031Dto, UpdateTABLE7031Dto, long>
{
    public TABLE7031Controller(ITABLE7031Service service) : base(service, dto => dto.NCODIGINT) { }
}
