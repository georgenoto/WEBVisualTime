using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9229;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9229Controller : CatalogController<TABLE9229Dto, CreateTABLE9229Dto, UpdateTABLE9229Dto, int>
{
    public TABLE9229Controller(ITABLE9229Service service)
        : base(service, "TABLE9229", "NPAY_ID", new[] { "NPAY_ID", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
