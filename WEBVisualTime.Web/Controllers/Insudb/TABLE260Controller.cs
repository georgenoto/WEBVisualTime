using WEBVisualTime.Servicios.Insudb.DTOs.TABLE260;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE260Controller : CatalogController<TABLE260Dto, CreateTABLE260Dto, UpdateTABLE260Dto, long>
{
    public TABLE260Controller(ITABLE260Service service)
        : base(service, "TABLE260", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
