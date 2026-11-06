using WEBVisualTime.Servicios.Insudb.DTOs.TABLE531;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE531Controller : CatalogController<TABLE531Dto, CreateTABLE531Dto, UpdateTABLE531Dto, int>
{
    public TABLE531Controller(ITABLE531Service service)
        : base(service, "TABLE531", "NSOURCE", new[] { "NSOURCE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
