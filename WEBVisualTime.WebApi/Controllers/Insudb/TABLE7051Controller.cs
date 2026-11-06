using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7051;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7051Controller : CrudApiController<TABLE7051Dto, CreateTABLE7051Dto, UpdateTABLE7051Dto, long>
{
    public TABLE7051Controller(ITABLE7051Service service) : base(service, dto => dto.NCODIGINT) { }
}
