using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9030;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9030Controller : CatalogController<TABLE9030Dto, CreateTABLE9030Dto, UpdateTABLE9030Dto, int>
{
    public TABLE9030Controller(ITABLE9030Service service)
        : base(service, "TABLE9030", "NDESRATING", new[] { "NDESRATING", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
