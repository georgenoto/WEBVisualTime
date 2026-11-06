using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9261;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9261Controller : CatalogController<TABLE9261Dto, CreateTABLE9261Dto, UpdateTABLE9261Dto, int>
{
    public TABLE9261Controller(ITABLE9261Service service)
        : base(service, "TABLE9261", "NORD_PROCEDURE", new[] { "NORD_PROCEDURE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
