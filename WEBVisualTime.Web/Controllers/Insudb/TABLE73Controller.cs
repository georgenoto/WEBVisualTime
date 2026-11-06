using WEBVisualTime.Servicios.Insudb.DTOs.TABLE73;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE73Controller : CatalogController<TABLE73Dto, CreateTABLE73Dto, UpdateTABLE73Dto, int>
{
    public TABLE73Controller(ITABLE73Service service)
        : base(service, "TABLE73", "NRELREQEXC", new[] { "NRELREQEXC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
