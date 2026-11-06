using WEBVisualTime.Servicios.Insudb.DTOs.TAB_GOALS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_GOALSController : CatalogController<TAB_GOALSDto, CreateTAB_GOALSDto, UpdateTAB_GOALSDto, int>
{
    public TAB_GOALSController(ITAB_GOALSService service)
        : base(service, "TAB_GOALS", "NCODE", new[] { "NCODE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
