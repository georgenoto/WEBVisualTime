using WEBVisualTime.Servicios.Insudb.DTOs.TABLE133;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE133Controller : CatalogController<TABLE133Dto, CreateTABLE133Dto, UpdateTABLE133Dto, int>
{
    public TABLE133Controller(ITABLE133Service service)
        : base(service, "TABLE133", "NUNACCODE", new[] { "NUNACCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
