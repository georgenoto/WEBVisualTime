using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9249;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9249Controller : CatalogController<TABLE9249Dto, CreateTABLE9249Dto, UpdateTABLE9249Dto, int>
{
    public TABLE9249Controller(ITABLE9249Service service)
        : base(service, "TABLE9249", "NSETTLEMENT_CONC", new[] { "NSETTLEMENT_CONC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
