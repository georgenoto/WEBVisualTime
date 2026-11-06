using WEBVisualTime.Servicios.Insudb.DTOs.STATUS_CLAIM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class STATUS_CLAIMController : CatalogController<STATUS_CLAIMDto, CreateSTATUS_CLAIMDto, UpdateSTATUS_CLAIMDto, int>
{
    public STATUS_CLAIMController(ISTATUS_CLAIMService service)
        : base(service, "STATUS_CLAIM", "NIDSTATUSCLAIM", new[] { "NIDSTATUSCLAIM", "SNAME", "SENABLE" }) { }
}
