using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9258;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9258Controller : CatalogController<TABLE9258Dto, CreateTABLE9258Dto, UpdateTABLE9258Dto, int>
{
    public TABLE9258Controller(ITABLE9258Service service)
        : base(service, "TABLE9258", "NSERV_ESTRUCT", new[] { "NSERV_ESTRUCT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
