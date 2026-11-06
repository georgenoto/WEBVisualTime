using WEBVisualTime.Servicios.Insudb.DTOs.TABLE40;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE40Controller : CatalogController<TABLE40Dto, CreateTABLE40Dto, UpdateTABLE40Dto, long>
{
    public TABLE40Controller(ITABLE40Service service)
        : base(service, "TABLE40", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
