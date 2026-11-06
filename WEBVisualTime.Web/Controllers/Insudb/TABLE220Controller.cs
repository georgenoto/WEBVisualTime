using WEBVisualTime.Servicios.Insudb.DTOs.TABLE220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE220Controller : CatalogController<TABLE220Dto, CreateTABLE220Dto, UpdateTABLE220Dto, int>
{
    public TABLE220Controller(ITABLE220Service service)
        : base(service, "TABLE220", "NVESTATUS", new[] { "NVESTATUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
