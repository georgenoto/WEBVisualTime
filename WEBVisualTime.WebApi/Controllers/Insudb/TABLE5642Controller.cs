using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5642;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5642Controller : CrudApiController<TABLE5642Dto, CreateTABLE5642Dto, UpdateTABLE5642Dto, int>
{
    public TABLE5642Controller(ITABLE5642Service service) : base(service, dto => dto.NCHANGESDAT) { }
}
