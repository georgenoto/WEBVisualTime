using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5505Controller : CatalogController<TABLE5505Dto, CreateTABLE5505Dto, UpdateTABLE5505Dto, int>
{
    public TABLE5505Controller(ITABLE5505Service service)
        : base(service, "TABLE5505", "NDISABILITY", new[] { "NDISABILITY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
