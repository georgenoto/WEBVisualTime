using WEBVisualTime.Servicios.Insudb.DTOs.TABLE901;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE901Controller : CrudApiController<TABLE901Dto, CreateTABLE901Dto, UpdateTABLE901Dto, long>
{
    public TABLE901Controller(ITABLE901Service service) : base(service, dto => dto.NCODIGINT) { }
}
