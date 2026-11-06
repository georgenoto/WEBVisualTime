using WEBVisualTime.Servicios.Insudb.DTOs.TABLE286;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE286Controller : CatalogController<TABLE286Dto, CreateTABLE286Dto, UpdateTABLE286Dto, long>
{
    public TABLE286Controller(ITABLE286Service service)
        : base(service, "TABLE286", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
