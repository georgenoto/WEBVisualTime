using WEBVisualTime.Servicios.Insudb.DTOs.TABLE20;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE20Controller : CatalogController<TABLE20Dto, CreateTABLE20Dto, UpdateTABLE20Dto, long>
{
    public TABLE20Controller(ITABLE20Service service)
        : base(service, "TABLE20", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
