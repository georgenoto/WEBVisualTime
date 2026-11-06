using WEBVisualTime.Servicios.Insudb.DTOs.TABLE591;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE591Controller : CrudApiController<TABLE591Dto, CreateTABLE591Dto, UpdateTABLE591Dto, int>
{
    public TABLE591Controller(ITABLE591Service service) : base(service, dto => dto.NSTATUS_BANKAUTH) { }
}
