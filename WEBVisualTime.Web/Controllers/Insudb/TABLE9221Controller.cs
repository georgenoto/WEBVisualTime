using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9221;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9221Controller : CatalogController<TABLE9221Dto, CreateTABLE9221Dto, UpdateTABLE9221Dto, int>
{
    public TABLE9221Controller(ITABLE9221Service service)
        : base(service, "TABLE9221", "NTYPEEXHAUS", new[] { "NTYPEEXHAUS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
