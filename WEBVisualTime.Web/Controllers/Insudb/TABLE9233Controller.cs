using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9233;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9233Controller : CatalogController<TABLE9233Dto, CreateTABLE9233Dto, UpdateTABLE9233Dto, string>
{
    public TABLE9233Controller(ITABLE9233Service service)
        : base(service, "TABLE9233", "STYPCALC_FLATPREM", new[] { "STYPCALC_FLATPREM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
