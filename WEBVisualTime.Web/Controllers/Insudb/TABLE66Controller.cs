using WEBVisualTime.Servicios.Insudb.DTOs.TABLE66;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE66Controller : CatalogController<TABLE66Dto, CreateTABLE66Dto, UpdateTABLE66Dto, int>
{
    public TABLE66Controller(ITABLE66Service service)
        : base(service, "TABLE66", "NCOUNTRY", new[] { "NCOUNTRY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
