using WEBVisualTime.Servicios.Insudb.DTOs.TABLE271;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE271Controller : CatalogController<TABLE271Dto, CreateTABLE271Dto, UpdateTABLE271Dto, int>
{
    public TABLE271Controller(ITABLE271Service service)
        : base(service, "TABLE271", "NEXC_CODE", new[] { "NEXC_CODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
