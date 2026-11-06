using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9021;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9021Controller : CatalogController<TABLE9021Dto, CreateTABLE9021Dto, UpdateTABLE9021Dto, int>
{
    public TABLE9021Controller(ITABLE9021Service service)
        : base(service, "TABLE9021", "NPROPAY", new[] { "NPROPAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
