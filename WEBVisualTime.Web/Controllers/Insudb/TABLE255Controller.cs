using WEBVisualTime.Servicios.Insudb.DTOs.TABLE255;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE255Controller : CatalogController<TABLE255Dto, CreateTABLE255Dto, UpdateTABLE255Dto, long>
{
    public TABLE255Controller(ITABLE255Service service)
        : base(service, "TABLE255", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
