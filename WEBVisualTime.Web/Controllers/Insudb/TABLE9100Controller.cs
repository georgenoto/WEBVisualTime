using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9100Controller : CatalogController<TABLE9100Dto, CreateTABLE9100Dto, UpdateTABLE9100Dto, int>
{
    public TABLE9100Controller(ITABLE9100Service service)
        : base(service, "TABLE9100", "NSHIPUSE", new[] { "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NSHIPUSE" }) { }
}
