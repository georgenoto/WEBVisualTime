using WEBVisualTime.Servicios.Insudb.DTOs.APPUSER;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class APPUSERController : CatalogController<APPUSERDto, CreateAPPUSERDto, UpdateAPPUSERDto, int>
{
    public APPUSERController(IAPPUSERService service)
        : base(service, "APPUSER", "NIDUSER", new[] { "NIDUSER", "SUSERNAME", "SNAME" }) { }
}
