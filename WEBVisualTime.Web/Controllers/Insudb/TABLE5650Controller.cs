using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5650;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5650Controller : CatalogController<TABLE5650Dto, CreateTABLE5650Dto, UpdateTABLE5650Dto, int>
{
    public TABLE5650Controller(ITABLE5650Service service)
        : base(service, "TABLE5650", "NCLASS_CONCEPT", new[] { "NCLASS_CONCEPT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
