using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8505;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8505Controller : CatalogController<TABLE8505Dto, CreateTABLE8505Dto, UpdateTABLE8505Dto, int>
{
    public TABLE8505Controller(ITABLE8505Service service)
        : base(service, "TABLE8505", "NTYPEPREMIUM", new[] { "NTYPEPREMIUM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
