using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9015;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9015Controller : CatalogController<TABLE9015Dto, CreateTABLE9015Dto, UpdateTABLE9015Dto, int>
{
    public TABLE9015Controller(ITABLE9015Service service)
        : base(service, "TABLE9015", "NACTBUS", new[] { "NACTBUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
