using WEBVisualTime.Servicios.Insudb.DTOs.TABLE30;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE30Controller : CatalogController<TABLE30Dto, CreateTABLE30Dto, UpdateTABLE30Dto, string>
{
    public TABLE30Controller(ITABLE30Service service)
        : base(service, "TABLE30", "SDISEXPRI", new[] { "SDISEXPRI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
