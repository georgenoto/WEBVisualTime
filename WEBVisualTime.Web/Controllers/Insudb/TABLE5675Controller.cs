using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5675;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5675Controller : CatalogController<TABLE5675Dto, CreateTABLE5675Dto, UpdateTABLE5675Dto, int>
{
    public TABLE5675Controller(ITABLE5675Service service)
        : base(service, "TABLE5675", "NINFTYPE", new[] { "NINFTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
