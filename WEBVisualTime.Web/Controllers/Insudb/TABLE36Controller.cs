using WEBVisualTime.Servicios.Insudb.DTOs.TABLE36;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE36Controller : CatalogController<TABLE36Dto, CreateTABLE36Dto, UpdateTABLE36Dto, int>
{
    public TABLE36Controller(ITABLE36Service service)
        : base(service, "TABLE36", "NPAYFREQ", new[] { "NPAYFREQ", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
