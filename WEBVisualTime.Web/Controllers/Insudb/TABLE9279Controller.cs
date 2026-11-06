using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9279;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9279Controller : CatalogController<TABLE9279Dto, CreateTABLE9279Dto, UpdateTABLE9279Dto, int>
{
    public TABLE9279Controller(ITABLE9279Service service)
        : base(service, "TABLE9279", "NSUBLIMIT_TYPE", new[] { "NSUBLIMIT_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
