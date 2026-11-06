using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7504;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7504Controller : CatalogController<TABLE7504Dto, CreateTABLE7504Dto, UpdateTABLE7504Dto, string>
{
    public TABLE7504Controller(ITABLE7504Service service)
        : base(service, "TABLE7504", "STYP_COMISS", new[] { "STYP_COMISS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
