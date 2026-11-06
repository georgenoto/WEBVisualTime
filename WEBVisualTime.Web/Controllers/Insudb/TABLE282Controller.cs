using WEBVisualTime.Servicios.Insudb.DTOs.TABLE282;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE282Controller : CatalogController<TABLE282Dto, CreateTABLE282Dto, UpdateTABLE282Dto, int>
{
    public TABLE282Controller(ITABLE282Service service)
        : base(service, "TABLE282", "NSTATPRINT", new[] { "NSTATPRINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
