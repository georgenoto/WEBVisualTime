using WEBVisualTime.Servicios.Insudb.DTOs.TABLE114;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE114Controller : CatalogController<TABLE114Dto, CreateTABLE114Dto, UpdateTABLE114Dto, long>
{
    public TABLE114Controller(ITABLE114Service service)
        : base(service, "TABLE114", "NSURRFREQ", new[] { "NSURRFREQ", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
