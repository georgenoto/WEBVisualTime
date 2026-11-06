using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1006Controller : CatalogController<TABLE1006Dto, CreateTABLE1006Dto, UpdateTABLE1006Dto, int>
{
    public TABLE1006Controller(ITABLE1006Service service)
        : base(service, "TABLE1006", "NPRIORITY", new[] { "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NPRIORITY" }) { }
}
