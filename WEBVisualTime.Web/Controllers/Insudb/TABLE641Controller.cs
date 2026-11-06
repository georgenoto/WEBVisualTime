using WEBVisualTime.Servicios.Insudb.DTOs.TABLE641;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE641Controller : CatalogController<TABLE641Dto, CreateTABLE641Dto, UpdateTABLE641Dto, long>
{
    public TABLE641Controller(ITABLE641Service service)
        : base(service, "TABLE641", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
