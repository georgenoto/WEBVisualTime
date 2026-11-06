using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7028Controller : CrudApiController<TABLE7028Dto, CreateTABLE7028Dto, UpdateTABLE7028Dto, long>
{
    public TABLE7028Controller(ITABLE7028Service service) : base(service, dto => dto.NRETURN_CODE) { }
}
