using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8606;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8606Controller : CatalogController<TABLE8606Dto, CreateTABLE8606Dto, UpdateTABLE8606Dto, int>
{
    public TABLE8606Controller(ITABLE8606Service service)
        : base(service, "TABLE8606", "NTYPE_GROUP", new[] { "NTYPE_GROUP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
