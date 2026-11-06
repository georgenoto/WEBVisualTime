using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9010;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9010Controller : CatalogController<TABLE9010Dto, CreateTABLE9010Dto, UpdateTABLE9010Dto, int>
{
    public TABLE9010Controller(ITABLE9010Service service)
        : base(service, "TABLE9010", "NSINCEYEAR", new[] { "NSINCEYEAR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
