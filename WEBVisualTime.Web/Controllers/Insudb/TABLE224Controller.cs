using WEBVisualTime.Servicios.Insudb.DTOs.TABLE224;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE224Controller : CatalogController<TABLE224Dto, CreateTABLE224Dto, UpdateTABLE224Dto, long>
{
    public TABLE224Controller(ITABLE224Service service)
        : base(service, "TABLE224", "NAUTOZONE", new[] { "NAUTOZONE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
