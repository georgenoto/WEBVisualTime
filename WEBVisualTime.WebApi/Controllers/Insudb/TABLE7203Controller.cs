using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7203Controller : CrudApiController<TABLE7203Dto, CreateTABLE7203Dto, UpdateTABLE7203Dto, long>
{
    public TABLE7203Controller(ITABLE7203Service service) : base(service, dto => dto.NCODIGINT) { }
}
