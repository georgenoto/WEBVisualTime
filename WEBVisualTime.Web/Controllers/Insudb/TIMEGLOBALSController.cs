using WEBVisualTime.Servicios.Insudb.DTOs.TIMEGLOBALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TIMEGLOBALSController : CatalogController<TIMEGLOBALSDto, CreateTIMEGLOBALSDto, UpdateTIMEGLOBALSDto, string>
{
    public TIMEGLOBALSController(ITIMEGLOBALSService service)
        : base(service, "TIMEGLOBALS", "SCODE", new[] { "SCODE", "DCOMPDATE", "NTYPEDATA", "SDESCRIPT", "NUSERCODE" }) { }
}
