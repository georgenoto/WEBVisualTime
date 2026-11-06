using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7001Controller : CrudApiController<TABLE7001Dto, CreateTABLE7001Dto, UpdateTABLE7001Dto, int>
{
    public TABLE7001Controller(ITABLE7001Service service) : base(service, dto => dto.NTYPEREQUEST) { }
}
