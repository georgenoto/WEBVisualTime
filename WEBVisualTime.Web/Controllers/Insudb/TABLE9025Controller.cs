using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9025;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9025Controller : CatalogController<TABLE9025Dto, CreateTABLE9025Dto, UpdateTABLE9025Dto, int>
{
    public TABLE9025Controller(ITABLE9025Service service)
        : base(service, "TABLE9025", "NRENTABILITY", new[] { "NRENTABILITY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
