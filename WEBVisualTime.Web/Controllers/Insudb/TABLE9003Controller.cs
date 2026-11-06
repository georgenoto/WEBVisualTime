using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9003;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9003Controller : CatalogController<TABLE9003Dto, CreateTABLE9003Dto, UpdateTABLE9003Dto, int>
{
    public TABLE9003Controller(ITABLE9003Service service)
        : base(service, "TABLE9003", "NAJUSTTYPE", new[] { "NAJUSTTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
