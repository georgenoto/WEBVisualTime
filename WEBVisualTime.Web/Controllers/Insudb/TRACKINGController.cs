using WEBVisualTime.Servicios.Insudb.DTOs.TRACKING;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TRACKINGController : CatalogController<TRACKINGDto, CreateTRACKINGDto, UpdateTRACKINGDto, int>
{
    public TRACKINGController(ITRACKINGService service)
        : base(service, "TRACKING", "ID", new[] { "ID", "FACTTIME", "HOSTSOURCE", "FORMPATH", "URLREFERRER", "USERAGENT", "FORMID", "PURCHASEORDER", "REMARK", "CALLEDFROMID" }) { }
}
