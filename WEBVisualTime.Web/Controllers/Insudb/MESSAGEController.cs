using WEBVisualTime.Servicios.Insudb.DTOs.MESSAGE;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class MESSAGEController : CatalogController<MESSAGEDto, CreateMESSAGEDto, UpdateMESSAGEDto, long>
{
    public MESSAGEController(IMESSAGEService service)
        : base(service, "MESSAGE", "NERRORNUM", new[] { "NERRORNUM", "DCOMPDATE", "SMESSAGED", "SSTATREGT", "NUSERCODE" }) { }
}
