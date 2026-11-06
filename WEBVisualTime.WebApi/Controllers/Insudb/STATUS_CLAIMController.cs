using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class STATUS_CLAIMController : CrudApiController<STATUS_CLAIMDto, CreateSTATUS_CLAIMDto, UpdateSTATUS_CLAIMDto, int>
{
    public STATUS_CLAIMController(ISTATUS_CLAIMService service) : base(service, dto => dto.NIDSTATUSCLAIM) { }
}
