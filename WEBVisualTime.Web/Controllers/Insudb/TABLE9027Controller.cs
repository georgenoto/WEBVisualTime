using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9027;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9027Controller : CatalogController<TABLE9027Dto, CreateTABLE9027Dto, UpdateTABLE9027Dto, int>
{
    public TABLE9027Controller(ITABLE9027Service service)
        : base(service, "TABLE9027", "NECONOMIC", new[] { "NECONOMIC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
