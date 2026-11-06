using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8300;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8300Controller : CatalogController<TABLE8300Dto, CreateTABLE8300Dto, UpdateTABLE8300Dto, int>
{
    public TABLE8300Controller(ITABLE8300Service service)
        : base(service, "TABLE8300", "NTYPE_RATEPROY", new[] { "NTYPE_RATEPROY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
