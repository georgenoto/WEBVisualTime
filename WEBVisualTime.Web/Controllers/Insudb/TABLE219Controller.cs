using WEBVisualTime.Servicios.Insudb.DTOs.TABLE219;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE219Controller : CatalogController<TABLE219Dto, CreateTABLE219Dto, UpdateTABLE219Dto, long>
{
    public TABLE219Controller(ITABLE219Service service)
        : base(service, "TABLE219", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
