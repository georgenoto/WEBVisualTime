using WEBVisualTime.Servicios.Insudb.DTOs.TABLE314;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE314Controller : CatalogController<TABLE314Dto, CreateTABLE314Dto, UpdateTABLE314Dto, int>
{
    public TABLE314Controller(ITABLE314Service service)
        : base(service, "TABLE314", "NEXP_ROUTINE", new[] { "NEXP_ROUTINE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
